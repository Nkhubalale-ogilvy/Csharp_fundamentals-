class MultuplicationTable
{
    public static void Multiplication()
    { 
        Console.WriteLine("Enter a number to display its multiplication table: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine($"Multiplication table for {number}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }   


    }
}