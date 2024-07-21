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
            Console.WriteLine($"Tarefa adicionada: {task.Name}");
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
                Console.WriteLine($"Tarefa atualizada: {task.Name}");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        public static void RemoveTask(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
                Console.WriteLine("Tarefa removida.");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }
    }
}
