class FunctionsAndDatastructures
{
    static void Main()
    {
        Console.WriteLine("Welcome to the functions and data structures program!");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Arithmetic Operations");

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

            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                break;
        }
    }
}
