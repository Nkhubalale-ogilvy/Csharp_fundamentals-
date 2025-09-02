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
}