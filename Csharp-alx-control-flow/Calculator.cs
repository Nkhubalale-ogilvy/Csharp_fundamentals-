public class Calculator
{
    public static void Calculate()
    {
        int num1, num2;

        Console.WriteLine("Enter the first number: ");
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer: ");
        }

        Console.WriteLine("Enter the second number: ");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer: ");
        }

        Console.WriteLine("Choose the operation (+, -, *, /): ");
        string? arithmeticOperator = Console.ReadLine();

        double? result = null;
        string? errorMessage = null;

        switch (arithmeticOperator)
        {
            case "+":
                result = num1 + num2;
                break;

            case "-":
                result = num1 - num2;
                break;

            case "*":
                result = num1 * num2;
                break;

            case "/":
                if (num2 != 0)
                    result = (double)num1 / num2;
                else
                    errorMessage = "Error! Division by zero is not allowed.";
                break;

            default:
                errorMessage = "Error! Invalid operation.";
                break;
        }

        if (errorMessage != null)
            Console.WriteLine(errorMessage);

        else
            Console.WriteLine($"The result is {result}");
    }
}
