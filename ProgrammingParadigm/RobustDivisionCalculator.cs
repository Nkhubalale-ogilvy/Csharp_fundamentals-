namespace ProgrammingParadigm;

public static class RobustDivisionCalculator
{
    public static string SafeDivide(string numerator, string denominator)
    {
        try
        {
            double num = Convert.ToDouble(numerator);
            double denom = Convert.ToDouble(denominator);

            if (denom == 0)
            {
                return "Error: Cannot divide by zero.";
            }

            return $"The result of the division is {num / denom}";
        }
        catch (FormatException)
        {
            return "Error: Please enter numeric values only.";
        }
        catch (OverflowException)
        {
            return "Error: The number is too large or too small.";
        }
    }

    public static void RunProgram()
    {
        Console.WriteLine(" Robust Division Calculator");

        Console.Write("Enter numerator: ");
        string? numerator = Console.ReadLine();

        Console.Write("Enter denominator: ");
        string? denominator = Console.ReadLine();

        string result = SafeDivide(numerator ?? "", denominator ?? "");
        Console.WriteLine(result);

    
        
    }
}