using System;
using System.Collections.Generic;

class TodoApp
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nTodo List Application");
            Console.WriteLine("1. View Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ViewTasks();
            }
            else if (choice == "2")
            {
                AddTask();
            }
            else if (choice == "3")
            {
                DeleteTask();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting... Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }

    static void ViewTasks()
    {
        Console.WriteLine("\nYour Tasks:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found!");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    static void AddTask()
    {
        Console.Write("\nEnter a new task: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Task added!");
    }

    static void DeleteTask()
    {
        ViewTasks();
        Console.Write("\nEnter the task number to delete: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
        {
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine("Task deleted!");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}
