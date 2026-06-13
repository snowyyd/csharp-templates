# C# Templates

A curated collection of personal C# project templates designed to streamline my development workflow and enforce consistent project structure.

## 🚀 Installation

Install the templates via `dotnet new`:
```
dotnet new install Snowyyd.Templates --nuget-source https://gitlab.com/api/v4/projects/77548339/packages/nuget/index.json
```

## 📦 Available Templates

List all available templates:
```
dotnet new list --author snowyyd
```

## 🛠️ Usage

Create a new project using a template:
```
dotnet new snowyyd.cs -n ProjectName -s SolutionName
```

This command instantiates the `snowyyd.cs` template, producing the following file structure:

```tree
ProjectName/
├── ProjectName
│   └── ProjectName.csproj
└── SolutionName.slnx
```

## 🔍 Comparing Templates

Most templates are based on the `templates/sdk` baseline. To understand how a template differs from the base, you can compare their contents using `git diff` or any other diff tool.

For example, to compare the base SDK template with the ASP.NET template:
```
git diff --no-index templates/sdk templates/asp.net
```

## 📜 Licensing

This repository, which contains the collection of C# templates (distributed as a .NET template package), is licensed under the MIT License.

Each template also includes its own `LICENSE` file for convenience. This is provided as a default and can be replaced or adjusted to suit your needs.
