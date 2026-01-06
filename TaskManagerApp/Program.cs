
public enum Priority
{
    Low,
    Medium,
    High,
    Critical
}

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter a comman (add, list, help, exit): ");
        string command = Console.ReadLine().ToLower().Trim();

        string addTaskMessage = command switch
        {
            "add" => "Adding a new task...",
            "list" => "Listing all tasks...",
            "exit" => "Exiting Task Manager.",
            _ => "Unknow command. Type 'help' for options."
        };

        Console.WriteLine(addTaskMessage);

        Priority priority = Priority.Low;
        string priorityMessage = priority switch
        {
            Priority.Low => "Can be done anytime.",
            Priority.Medium => "Should be done soon.",
            Priority.High => "Requires immediate attention",
            Priority.Critical => "Urgent, requires immediate action.",
            _ => "Unknown priority value"
        };

        Console.WriteLine(priorityMessage);

        bool isPremiumUser = true;
        string accountTypeMessage = isPremiumUser ? "Premium Account" : "Standart Account";
        Console.WriteLine(accountTypeMessage);

        int com;
        do
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Choose: ");
            com = int.Parse(Console.ReadLine());

            string mensagemCalculadora = com switch
            {
                1 => "Performing addition...",
                2 => "Performing subtraction...",
                3 => "Exiting...",
                _ => "Unknown"
            };

            Console.WriteLine(mensagemCalculadora);

        } while(com != 3);
    }
}