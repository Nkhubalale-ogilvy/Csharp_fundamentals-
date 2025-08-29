class ArithmeticOperations
{
    public static string PerformOperations(decimal a, decimal b, string operation)
    {
        if (operation == "add")
        {
            return $"{a +b}";

        }
        else if (operation == "subtract")
        {
            return $" {a - b}";
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

        else if (operation == "divide")
        {
            if (b != 0)
                return $"{a / b}";
            else
                return "Error: Division by zero is not allowed";
        }
        else

            return "Error: Invalid operation";
    }
    
 }