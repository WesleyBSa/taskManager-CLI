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
                Console.WriteLine("Comando não fornecido.");
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
                        Console.WriteLine("Nome da tarefa não fornecido.");
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
                        Console.WriteLine("Parâmetros inválidos para atualizar.");
                    }
                    break;
                case "remove":
                    if (args.Length > 1 && int.TryParse(args[1], out int removeId))
                    {
                        TaskService.RemoveTask(removeId);
                    }
                    else
                    {
                        Console.WriteLine("Parâmetros inválidos para remover.");
                    }
                    break;
                default:
                    Console.WriteLine("Comando desconhecido.");
                    break;
            }
        }
    }
}
