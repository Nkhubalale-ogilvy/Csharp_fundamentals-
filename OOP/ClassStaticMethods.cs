public class Calculator
{
    public static string CalculationType = "Arithmetic Operations";
    
    public static double Add(double a, double b)
    {
        return a + b;
    }
    
    public double Multiply(double a, double b)   // The keyword static is missing and therfore making this a class method, relying on instance of the class to be called
    {
        Console.WriteLine($"Calculation type: {CalculationType}");
        return a * b;
    }
}

public class ClassStaticMethodsDemo
{
    public static void Run()
    {
        double sum = Calculator.Add(5, 10);
        Console.WriteLine($"Sum: {sum}");
        
        Calculator calc = new Calculator();
        double product = calc.Multiply(5, 10);  // Instance of the class is required to call the Multiply method
        Console.WriteLine($"Product: {product}");
    }
}