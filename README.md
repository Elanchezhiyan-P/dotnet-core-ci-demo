# 🧪 SampleAppWithTests

A minimal .NET Core console application with integrated unit tests using **xUnit** and **GitHub Actions CI**. This repository demonstrates:

- .NET project structure with test coverage
- Writing and running unit tests
- Continuous Integration using GitHub Actions
- Test result reporting

---

## 📁 Project Structure

```
dotnet-core-ci-demo/
├── .github/workflows/
│ └── dotnet-ci.yml # GitHub Actions CI workflow
├── dotnet-core-ci-demo/ # Main console application
│ └── Program.cs
├── dotnet-core-ci-demo.Tests/ # xUnit test project
│ └── UnitTest1.cs
└── dotnet-core-ci-demo.sln # Solution file
```

## 🚀 Getting Started

### 🔧 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Git CLI
- GitHub account (for CI)

---

### 🏗️ Setup Instructions

```bash
# Clone the repository
git clone https://github.com/Elanchezhiyan-P/dotnet-core-ci-demo.git
cd dotnet-core-ci-demo
```

# Restore dependencies
```dotnet restore```

# Build the solution
```dotnet build```

# Run the app
```dotnet run --project dotnet-core-ci-demo```

### 🧪 Running Tests
The solution uses xUnit for unit testing.

```
dotnet test 
```

Expected output:

```Passed!  - Failed: 0, Passed: 3, Skipped: 0```

## 📊 Test Result Reporting
Test results are automatically generated and published on pull requests using GitHub annotations.

## 🙌 Contributions
Feel free to fork and submit a PR for any enhancements or fixes!
