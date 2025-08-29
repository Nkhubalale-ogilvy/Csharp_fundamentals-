class ControlFlow
{
    static void Main()
    {
        Console.WriteLine("Choose a program to run:");
        Console.WriteLine("1. Reminder");
        Console.WriteLine("2. Calculator");
        Console.WriteLine("3. Multiplication Table");
        Console.WriteLine("4. Pattern Drawing");
        Console.WriteLine("5. Weather Advice");
        Console.Write("Enter your choice (1, 2 , 3, 4 or 5): ");

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
                
            case "4":
                PatternDrawing.DrawPattern();
                break;

            case "5":
                WeatherAdvice.Advise();
                break;

            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                break;
        }
    }
}