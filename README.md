# AITravelAgentUsingGithubModelAndSemanticKernelSDK
This project/repo is to explore the Semantic Kernel SDK and OpenAI/Supported Model using GitHub Models.\
Most of the steps can be followed by MS Learning as below:

## [Guided project - Create an AI travel agent ](https://learn.microsoft.com/en-us/training/modules/guided-project-create-ai-travel-agent/)


[![GitHub license](https://img.shields.io/github/license/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK.svg)](https://github.com/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK/blob/master/LICENSE.txt)
[![GitHub contributors](https://img.shields.io/github/contributors/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK.svg)](https://GitHub.com/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK/graphs/contributors/)
[![GitHub issues](https://img.shields.io/github/issues/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK.svg)](https://GitHub.com/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK)
[![GitHub pull-requests](https://img.shields.io/github/issues-pr/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK.svg)](https://GitHub.com/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK)

[![GitHub watchers](https://img.shields.io/github/watchers/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK.svg?style=social&label=Watch)](https://GitHub.com/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK)
[![GitHub forks](https://img.shields.io/github/forks/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK.svg?style=social&label=Fork)](https://GitHub.com/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK/network/)
[![GitHub stars](https://img.shields.io/github/stars/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK.svg?style=social&label=Star)](https://GitHub.com/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK/stargazers/)

### Setup and run the Codebase
#### Recommended to use Visual Studio 2022 with .NET 9.0 SDK
1. Install the nuget packages as below:
```bash
dotnet add package  Microsoft.Extensions.Configuration.UserSecrets --version 9.0.1
dotnet add package  Microsoft.SemanticKernel --version 1.33.0
dotnet add package  Microsoft.SemanticKernel.Plugins.Core --version 1.33.0-alpha
dotnet add package  Microsoft.SemanticKernel.PromptTemplates.Handlebars --version 1.33.0
```

2. And build the project or rebuild the solution:
```bash
dotnet build
```

3. To access the above [GitHub Models](https://github.com/marketplace/models), you need to create 
a GitHub PAT (Generate a [GitHub Personal Access Token (PAT)](https://github.com/settings/tokens))\
and Set in Environment Variable on local machine in  using commands as below:


```bash
dotnet user-secrets init
dotnet user-secrets set "GH_PAT" "< PAT >"
```

4. In the terminal, run the project with the command:
```bash
dotnet run
```

## References
- [Introduction to Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/overview/)
- [Develop generative AI apps with Azure OpenAI and Semantic Kernel](https://learn.microsoft.com/en-us/training/paths/develop-ai-agents-azure-open-ai-semantic-kernel-sdk/)
- [MSLearn-Develop-AI-Agents-with-Azure-OpenAI-and-Semantic-Kernel-SDK](https://github.com/MicrosoftLearning/MSLearn-Develop-AI-Agents-with-Azure-OpenAI-and-Semantic-Kernel-SDK)

## Author

👤 **Tarak Chandra Sarkar**

* Github: [@tarak-chandra-sarkar](https://github.com/Tarak-Chandra-Sarkar)
* LinkedIn: [@tarak-chandra-sarkar](https://www.linkedin.com/in/tarak-chandra-sarkar/)

## 🤝 Contributing

N/A

## Show your support

Give a ⭐️ if this project helped you!

## 📝 License

Copyright &copy; 2025 [Tarak Chandra Sarkar](https://github.com/Tarak-Chandra-Sarkar/AITravelAgentUsingGithubModelAndSemanticKernelSDK).

This project is [MIT](/LICENSE) licensed.

***