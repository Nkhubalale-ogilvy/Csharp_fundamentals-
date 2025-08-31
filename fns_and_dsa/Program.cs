class FunctionsAndDatastructures
{
    static void Main()
    {
        Console.WriteLine("Welcome to the functions and data structures program!");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Arithmetic Operations");
        Console.WriteLine("2. Temperature Conversion");
        Console.WriteLine("3. Shopping List Manager");
        Console.WriteLine("4. Explore Date and Time");

        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                ArithmeticOperations.ExecuteArithmetic();
                break;



            case "2":
                TemperatureConversionTool.ConvertTemperature();

                break;

            case "3":
                Shopping.DoShopping();
                break;

            case "4":
                ExploreDatetime.ExploreDateTime();  
                break;


            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                break;
        }
    }
}