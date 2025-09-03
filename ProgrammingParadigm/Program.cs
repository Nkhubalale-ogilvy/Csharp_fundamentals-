namespace ProgrammingParadigm
{
 class Program
 {
        static void Main()
        {
            Console.WriteLine("Which program would you like to run?");
            Console.WriteLine("1. Functions and Data Structures");
            Console.WriteLine("2. Robust Division Calculator");
            Console.WriteLine("3. Bank Account Management");
            Console.Write("Enter your choice (1-3): ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
    
                case "2":
                    RobustDivisionCalculator.RunProgram();
                    break;

                    
                case "3":
                    BankAccount.RunProgram();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Exiting program.");
                    break;
            }         
     }
 }
}