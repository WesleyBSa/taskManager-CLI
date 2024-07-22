# TaskManagerCLI

![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)

## Introduction

TaskManagerCLI is a simple command-line interface (CLI) application for managing tasks. It allows you to add, list, update, and remove tasks directly from the terminal.

## Technologies Used

- **C#**: The programming language used for the project.
- **.NET**: The framework used to build and run the application.

## Prerequisites

To run this project, you will need:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 8.0 or later)

## Getting Started

Follow these steps to set up and run the project:

### 1. Clone the Repository

```sh
git clone https://github.com/your-username/TaskManagerCLI.git
cd TaskManagerCLI
```

### 2. Create the Project

If you haven't already created the project, you can do so with the following command:

```sh
dotnet new console -n TaskManagerCLI
cd TaskManagerCLI
```

### 3. Add Project Files

Ensure the following files exist in your project:

#### Program.cs
#### TaskService.cs
#### TaskModel.cs


### 4. Build and Run the Project

Navigate to the project directory and use the following commands to run the application:

```sh
dotnet build
dotnet run [command] [parameters]
```

## Usage Instructions

Here are the available commands and their usage:

- **Add a task**:
  ```sh
  dotnet run add "Buy milk"
  ```

- **List all tasks**:
  ```sh
  dotnet run list
  ```

- **Update a task**:
  ```sh
  dotnet run update 1 "Buy bread"
  ```

- **Remove a task**:
  ```sh
  dotnet run remove 1
  ```

## Contributing

If you would like to contribute to this project, please fork the repository and submit a pull request. We welcome all contributions!

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---
