class Program
{
    static void Main()
    {
        Console.WriteLine("OOP Concepts Demo\n");
        Console.WriteLine("\n --- Polymorphism Demo ---\n");

        PolymorphismDemo.RunDemo();

        Console.WriteLine("\n --- Book Demo ---\n");

        RunBook.Run();

        Console.WriteLine("\n ---  Static and Class Methods Demo ---\n");

        ClassStaticMethodsDemo.Run();

        Console.WriteLine("\n --- Library System Demo ---\n");

        LibrarySystem.RunDemo();

        Console.WriteLine("\nEnd of OOP Concepts Demo");
    }     
}
