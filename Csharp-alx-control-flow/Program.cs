class ControlFlow
{
    static void Main()
    {
        Console.WriteLine("Choose a program to run:");
        Console.WriteLine("1. Reminder");
        Console.WriteLine("2. Calculator");
        Console.WriteLine("3. Multiplication Table");
        Console.Write("Enter your choice (1, 2 or 3): ");

        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Reminder.Remind();
                break;

            case "2":
                Calculator.Calculate();
                break;

            case "3":
                MultuplicationTable.Multiplication();
                break;
                
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                break;
        }
    }
}