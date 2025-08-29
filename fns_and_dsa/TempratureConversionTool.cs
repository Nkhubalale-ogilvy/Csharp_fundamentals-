class TemperatureConversionTool
{
    public static void ConvertTemperature()
    {
        Console.WriteLine("Welcome to the Temperature Converter! \nPlease select the conversion type:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");

        string? conversionChoice = Console.ReadLine();
        if (conversionChoice != "1" && conversionChoice != "2")
        {
            Console.WriteLine("Invalid choice. Exiting...");
            return;
        }

        Console.Write("Enter the temperature to convert: ");
        if (!double.TryParse(Console.ReadLine(), out double temperature))
        {
            Console.WriteLine("Invalid temperature. Exiting...");
            return;
        }

        if (conversionChoice == "1")
        {
            string fahrenheit = CelsiusToFahrenheit(temperature);
            Console.WriteLine($"{temperature}°C is {fahrenheit}");
        }
        else
        {
            string celsius = FahrenheitToCelsius(temperature);
            Console.WriteLine($"{temperature}°F is {celsius}");
        }
    }

    public static string CelsiusToFahrenheit(double celsius)
    {
        try
        {
            double result = (celsius * 9 / 5) + 32;
            return $"{result}°F";
        }
        catch (Exception e)
        {
            return $"Error: {e.Message}";
        }
    }

    public static string FahrenheitToCelsius(double fahrenheit)
    {
        try
        {
            double result = (fahrenheit - 32) * 5 / 9;
            return $"{result}°C";
        }
        catch (Exception e)
        {
            return $"Error: {e.Message}";
        }
    }
}
