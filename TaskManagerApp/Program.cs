Console.Write("Enter a comman (add, list, help, exit):");
string command = Console.ReadLine().ToLower().Trim();

if (command == "add")
{
    Console.WriteLine("--- Adding a new task ---");
}
else if (command == "list")
{
    Console.WriteLine("--- Listing all Tasks ---");
}
else if (command == "help")
{
    Console.WriteLine("Help");
}
else if (command == "exit")
{
    Console.WriteLine("Exiting the Task Manager. Goodbye!");
}
else
{
    Console.WriteLine($"Unknow command: '{command}'.");
}

Console.Write("Enter a task priority (1: High, 2: Medium, 3: Low): ");
string priorityInput = Console.ReadLine();
int priority = int.Parse(priorityInput);

if (priority == 1)
{
    Console.WriteLine($"Priority task {1}: High");
}
else if (priority == 2)
{
    Console.WriteLine($"Priority task {2}: Medium");
}
else if (priority == 3)
{
    Console.WriteLine($"Priority task {3}: Low");
}
else
{
    Console.WriteLine($"Priority {priorityInput} not found, insert a valid input");
}

bool isPremiumUser = true;
string accountTypeMessage = isPremiumUser ? "Premium Account" : "Standart Account";
Console.WriteLine(accountTypeMessage);