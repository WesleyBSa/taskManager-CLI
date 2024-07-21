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

```csharp
using System;
using System.Collections.Generic;

namespace TaskManagerCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Command not provided.");
                return;
            }

            switch (args[0].ToLower())
            {
                case "add":
                    if (args.Length > 1)
                    {
                        TaskService.AddTask(args[1]);
                    }
                    else
                    {
                        Console.WriteLine("Task name not provided.");
                    }
                    break;
                case "list":
                    TaskService.ListTasks();
                    break;
                case "update":
                    if (args.Length > 2 && int.TryParse(args[1], out int updateId))
                    {
                        TaskService.UpdateTask(updateId, args[2]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid parameters for update.");
                    }
                    break;
                case "remove":
                    if (args.Length > 1 && int.TryParse(args[1], out int removeId))
                    {
                        TaskService.RemoveTask(removeId);
                    }
                    else
                    {
                        Console.WriteLine("Invalid parameters for remove.");
                    }
                    break;
                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
    }
}
```

#### TaskService.cs

```csharp
using System;
using System.Collections.Generic;

namespace TaskManagerCLI
{
    public static class TaskService
    {
        private static List<TaskModel> tasks = new List<TaskModel>();
        private static int nextId = 1;

        public static void AddTask(string taskName)
        {
            var task = new TaskModel { Id = nextId++, Name = taskName };
            tasks.Add(task);
            Console.WriteLine($"Task added: {task.Name}");
        }

        public static void ListTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Id}. {task.Name}");
            }
        }

        public static void UpdateTask(int id, string newName)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.Name = newName;
                Console.WriteLine($"Task updated: {task.Name}");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        public static void RemoveTask(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
                Console.WriteLine("Task removed.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }
    }
}
```

#### TaskModel.cs

```csharp
namespace TaskManagerCLI
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
```

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
