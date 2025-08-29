class FunctionsAndDatastructures
{
    static void Main()
    {
        Console.WriteLine("Welcome to the functions and data structures program!");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Arithmetic Operations");
        Console.WriteLine("2. Temperature Conversion");

        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                decimal num1, num2;

                Console.Write("Enter the first number: ");
                while (!decimal.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid number entered. Try again.");
                }

                Console.Write("Enter the second number: ");
                while (!decimal.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid number entered. Try again.");
                }

                Console.Write("Enter the operation (add, subtract, multiply, divide, modulus): ");
                string? operation = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(operation))
                {
                    Console.WriteLine("Invalid operation. Exiting...");
                    return;
                }

                operation = operation.Trim().ToLower();

                string result = ArithmeticOperations.PerformOperations(num1, num2, operation);
                Console.WriteLine($"Result: {result}");
                break;



            case "2":

                Console.WriteLine("Welcome to the Temperature Converter! \n Please select the conversion type:");
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Fahrenheit to Celsius");

                string? conversionChoice = Console.ReadLine();
                if (conversionChoice != "1" && conversionChoice != "2")
                {
                    Console.WriteLine("Invalid choice. Exiting...");
                    return;
                }

                else
                {
                    // do nothing, maybe refactor later
                }


                Console.Write("Enter the temperature to convert: ");
                if (!double.TryParse(Console.ReadLine(), out double temperature))
                {
                    Console.WriteLine("Invalid temperature. Exiting...");
                    return;
                }

                else
                {
                    // do nothing, maybe refactor later
                }


                if (conversionChoice == "1")
                {

                    string fahrenheit = TemperatureConversionTool.CelsiusToFahrenheit(temperature);
                    Console.WriteLine($"{temperature}°C is {fahrenheit}");

                }

                else
                {
                    string celsius = TemperatureConversionTool.FahrenheitToCelsius(temperature);
                    Console.WriteLine($"{temperature}°F is {celsius}");


                }

                break;





            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                break;
        }
    }
}