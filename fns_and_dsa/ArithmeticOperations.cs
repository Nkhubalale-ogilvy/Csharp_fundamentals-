class ArithmeticOperations
{
    public static string PerformOperations(decimal a, decimal b, string operation)
    {
        try
        {


            if (operation == "add")
            {
                return $"{a + b}";

            }
            else if (operation == "subtract")
            {
                return $"{a - b}";
            }
            else if (operation == "multiply")
            {
                return $"{a * b}";
            }
            else if (operation == "divide")
            {
                if (b != 0)
                    return $"{a / b}";
                else
                    return "Error: Division by zero is not allowed";
            }

            else if (operation == "modulus")
            {
                if (b != 0)

                    return $"{a % b}";


                else
                    return "Error: Modulus by zero is not allowed";
            }
            else
            {

                return "Error: Invalid operation";
            }
        }
        catch (Exception e)
        {
            return $"Error: {e.Message}";
        }
    }

   
   
       public static void ExecuteArithmetic()
    {
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

        string result = PerformOperations(num1, num2, operation);
        Console.WriteLine($"Result: {result}");
    }
    
 }