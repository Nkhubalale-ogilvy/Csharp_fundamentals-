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
    
    public static int RunProgram(string[] Arguments)
    {
        if (Arguments.Length != 2)
        {
           Console.WriteLine("Error: Please provide exactly two numbers.");
           Console.WriteLine("Example: dotnet run 10 2");
           Console.WriteLine("This will divide 10 by 2.");
           return 1;
        }

        string numerator = Arguments[0];
        string denominator = Arguments[1];

        string result = SafeDivide(numerator, denominator);
        Console.WriteLine(result);

        return 0;
        
    }
}