using Microsoft.SemanticKernel;
using Microsoft.Extensions.Configuration;
using System.ClientModel;
using OpenAI;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.PromptTemplates.Handlebars;

public class Program
{
    public static async Task Main(string[] args)
    {
        // Create a chat completion service with a model from GitHub Models 
        var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
        //var modelId = "Phi-3.5-mini-instruct";
        var modelId = "gpt-4o-mini";
        var uri = "https://models.inference.ai.azure.com";
        var githubPAT = config["GH_PAT"];

        // create client
        var client = new OpenAIClient(new ApiKeyCredential(githubPAT), new OpenAIClientOptions { Endpoint = new Uri(uri) });

        // Create a chat completion service
        var builder = Kernel.CreateBuilder();
        builder.AddOpenAIChatCompletion(modelId, client);

        // Get the chat completion service
        Kernel kernel = builder.Build();


        string handlebarsPrompt = """
            <message role="system">Instructions: Before providing the the user with a travel itinerary, ask how many days their trip is.</message>
            <message role="user">I'm going to Rome. Can you create an itinerary for me?</message>
            <message role="assistant">Sure, how many days is your trip?</message>
            <message role="user">{{input}}</message>
            """;

        var templateFactory = new HandlebarsPromptTemplateFactory();

        var promptTemplateConfig = new PromptTemplateConfig()
        {
            Template = handlebarsPrompt,
            TemplateFormat = "handlebars",
            Name = "CreateItenary"
        };

        kernel.ImportPluginFromType<CurrencyConverter>();

        var function = kernel.CreateFunctionFromPrompt(promptTemplateConfig, templateFactory);
        var plugin = kernel.CreatePluginFromFunctions("TravelItinerary", [function]);
        kernel.Plugins.Add(plugin);

        kernel.Plugins.AddFromType<FlightBookingPlugin>("FlightBooking");
        kernel.Plugins.AddFromType<HotelBookingPlugin>("HotelBooking");
        kernel.FunctionInvocationFilters.Add(new PermissionFilter());

        OpenAIPromptExecutionSettings settings = new()
        {
            FunctionChoiceBehavior = FunctionChoiceBehavior.Auto()
        };

        var history = new ChatHistory();

        history.AddSystemMessage("Before providing destination recommendations, ask the user if they have a budget for their trip.");

        Console.WriteLine("Press enter to exit");
        Console.WriteLine("Assistant: How may I help you?");
        Console.Write("User: ");

        string input = Console.ReadLine();

        while (input != "")
        {
            history.AddUserMessage(input);
            await GetReply();
            Console.Write("User: ");
            input = Console.ReadLine()!;
        }

        async Task GetReply()
        {
            var reply = await kernel.GetRequiredService<IChatCompletionService>().GetChatMessageContentAsync(
                history,
                executionSettings: settings,
                kernel: kernel
            );

            Console.WriteLine("Assistant: " + reply.ToString());
            history.AddAssistantMessage(reply.ToString());
        }



        Console.ReadKey();
    }
}