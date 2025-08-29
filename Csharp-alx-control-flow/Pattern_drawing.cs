class PatternDrawing
{
        
    public static void DrawPattern()
    {
        Console.WriteLine("Enter the size of the square pattern: ");
        if (int.TryParse(Console.ReadLine(), out int size))
        {
            if (size <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
            }
            else
            {
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}