class Shopping
{
    public static void DisplayMenu()
    {
        Console.WriteLine("1. Add Item");
        Console.WriteLine("2. View Items");
        Console.WriteLine("3. Remove Item");
        Console.WriteLine("4. Exit");
    }

    public static void AddItem(List<string> shoppingList)
    {
        string? item = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(item))
        {
            shoppingList.Add(item.Trim());
            Console.WriteLine($"{item} has been added to your shopping list.");
        }
        else
        {
            Console.WriteLine("Invalid item. Please try again.");
        }
    }

    public static void RemoveItem(List<string> shoppingList)
    {
        Console.Write("Enter the item to remove: ");
        string? item = Console.ReadLine();
        if (shoppingList.Remove(item.Trim()))
        {
            Console.WriteLine($"{item} has been removed from your shopping list.");
        }
        else
        {
            Console.WriteLine($"{item} was not found in your shopping list.");
        }
    }

    public static void ViewItems(List<string> shoppingList)
    {
        if (shoppingList.Count == 0)
        {
            Console.WriteLine("Your shopping list is empty.");
        }
        else
        {
            Console.WriteLine("Your Shopping List:");
            foreach (var item in shoppingList)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }

    public static void DoShopping()
    { 
        List<string> shoppingList = new List<string>();
        while (true)
        {
            DisplayMenu();
            Console.Write("Choose an option (1-4): ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddItem(shoppingList);
                    break;
                case "2":
                    ViewItems(shoppingList);
                    break;
                case "3":
                    RemoveItem(shoppingList);
                    break;
                case "4":
                    Console.WriteLine("Exiting the Shopping List Manager. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
 }