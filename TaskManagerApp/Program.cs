using System.Collections.Generic;

public class TaskManager
{
    private List<string> tasks = new List<string>();

    public void DisplayMenu()
    {
        Console.WriteLine("\n--- Task Manager Menu ---");
        Console.WriteLine("1. Add a new task");
        Console.WriteLine("2. List all tasks");
        Console.WriteLine("3. Exit");
        Console.WriteLine("4. Clear all Tasks");
        Console.Write("Enter your choice: ");
    }

    public void AddTask()
    {
        Console.Write("Enter the task description: ");
        string? taskDescription = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(taskDescription))
        {
            tasks.Add(taskDescription);
            Console.WriteLine("Task added successfully!");
        }
        else
        {
            Console.WriteLine("Task description cannot be empty.");
        }
    }

    public void ListTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("\nNo tasks to display.");
            return;
        }

        Console.WriteLine("\n--- Your Tasks ---");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    public void ClearAllTasks()
    {
        // REMOVER TASKS
        Console.WriteLine("Tasks removed successfully!");
    }

    public void Run()
    {
        bool running = true;
        while (running)
        {
            DisplayMenu();
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ListTasks();
                    break;
                case "3":
                    Console.WriteLine("Exiting Task Manager. Goodbye!");
                    running = false;
                    break;
                case "4":
                    ClearAllTasks();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again");
                    break;
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TaskManager manager = new TaskManager();
        manager.Run();
    }
}