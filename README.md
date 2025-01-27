## AITravelAgentUsingGithubModelAndSemanticKernelSDK
This repo is to explore the Semantic Kernel SDK and OpenAI Model using GitHib Models guided by 
MS Learning as below:
https://learn.microsoft.com/en-us/training/modules/guided-project-create-ai-travel-agent/

### Setup and run the Codebase
#### Recommended to use Visual Studio 2022 with .NET 9.0 SDK
Install the nuget packages as below:
```bash
dotnet add package  Microsoft.Extensions.Configuration.UserSecrets --version 9.0.1
dotnet add package  Microsoft.SemanticKernel --version 1.33.0
dotnet add package  Microsoft.SemanticKernel.Plugins.Core --version 1.33.0-alpha
dotnet add package  Microsoft.SemanticKernel.PromptTemplates.Handlebars --version 1.33.0
```

And build the project or rebuild the solution:
```bash
dotnet build
```

To access the above GitHub Models, you need to create GitHub PAT Token and 
set into local machine in Environment Variable using following commands:

Generate a [GitHub Personal Access Token (PAT)](https://github.com/settings/tokens)
```bash
dotnet user-secrets init
dotnet user-secrets set "GH_PAT" "< PAT >"
```

In the terminal, run the project with the command:
```bash
dotnet run
```
