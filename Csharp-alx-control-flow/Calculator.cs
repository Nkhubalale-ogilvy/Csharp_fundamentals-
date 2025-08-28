public class Calculator
{
    public static void Calculate()
    { 
        int num1, num2;
        string result;
        

        Console.WriteLine("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Choose the operation (+, -, *, /): ");
        string? arithmeticOperator = Console.ReadLine();



        switch (arithmeticOperator)
        {
            case "+":
                result = (num1 + num2).ToString();
                break;

            case "-":
                result = (num1 - num2).ToString();
                break;

            case "*":
                result = (num1 * num2).ToString();
                break;

            case "/":
                if (num2 != 0)
                {
                    result = (num1 / (double)num2).ToString();
                }
                else
                {
                    result = "Error! Division by zero is not allowed.";
                }
                break;

            default:

                result = "Error! Invalid operation.";
                break;

        }


        if (double.TryParse(result, out double numericResult))
        {
            Console.WriteLine($"The result is {numericResult}");
        }
        else
        {
            Console.WriteLine(result);
        }




    }
}   

