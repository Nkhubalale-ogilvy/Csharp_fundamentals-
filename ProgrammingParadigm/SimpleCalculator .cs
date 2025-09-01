class SimpleCalculator
{
    ///  A calculator that can add, subtract, multiply, and divide two numbers.

    public static double Add(double a, double b) => a + b;

    public static double Subtract(double a, double b) => a - b;

    public static double Multiply(double a, double b) => a * b;
    
    public static double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Denominator cannot be zero.");
        return a / b;
    }
    
}