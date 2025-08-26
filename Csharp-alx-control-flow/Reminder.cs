public class Reminder
{
    public static void Remind()
    {
        Console.WriteLine("Enter your task: ");
        string? task = Console.ReadLine();

        Console.WriteLine("Enter Priority level as high/medium/low: ");
        string? priority = Console.ReadLine();

        Console.WriteLine("Is it time-bound? (yes/no): ");
        string? timeBound = Console.ReadLine();

        string reminder = "";

        if (priority != null)
        {
            priority = priority.ToLower();
        }


        if (timeBound != null)
        {
            timeBound = timeBound.ToLower();
        }  

        switch (priority)
        {
            case "high":
                reminder = $"Reminder: {task} is of high priority";
                break;
            case "medium":
                reminder = $"Reminder: {task} is of medium priority";
                break;
            case "low":
                reminder = $"Reminder: {task} is of low priority";
                break;
            default:
                reminder = $"Your task {task} has an Invalid priority level entered.";
                break;
        }

        if (timeBound == "yes")
        {
            reminder += " that requires immediate attention today!";
        }

        Console.WriteLine(reminder);
    }
}
