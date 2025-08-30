class ExploreDatetime
{
    public static void ShowCurrentDateTime()
    {
        DateTime CurrentDate = DateTime.Now;
        Console.WriteLine($"Current Date and Time: {CurrentDate}");
    }

    public static void CalculateFutureDate()
    {
        Console.Write("Enter number of days to add: ");
        if (int.TryParse(Console.ReadLine(), out int daysToAdd))
        {
            DateTime futureDate = DateTime.Now.AddDays(daysToAdd);
            Console.WriteLine($"Date after {daysToAdd} days: {futureDate}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    public static void ExploreDateTime()
    {
        ShowCurrentDateTime();

        Console.WriteLine("Would you like to calculate a future date? (yes/no)");
        string? response = Console.ReadLine();

        if (response != null && response.Trim().ToLower() == "yes")


        {
            CalculateFutureDate();
        }

        else if (response != null && response.Trim().ToLower() == "no")
        {
            Console.WriteLine(" You chose not to calculate a future date.   Exiting date exploration.");
        }   
        else
        {
            Console.WriteLine("Invalid response. Please enter 'yes' or 'no'.    Exiting date exploration.");
        }
    }
}
