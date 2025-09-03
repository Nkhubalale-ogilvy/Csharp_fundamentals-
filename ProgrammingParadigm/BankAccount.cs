namespace ProgrammingParadigm;

public class BankAccount(double initialBalance = 0)
{
    private double _accountBalance = initialBalance;

    public void Deposit(double amount)
    {
        _accountBalance += amount;
    }

    public bool Withdraw(double amount)
    {
        if (_accountBalance >= amount)
        {
            _accountBalance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Current Balance: R{_accountBalance:F2}");
    }

    public static void RunProgram()
    {
    Console.WriteLine("Bank Account Management");

    Console.Write("Enter initial balance: R");
    double initialBalance = 100; 
    if (double.TryParse(Console.ReadLine(), out double balance))
    {
        initialBalance = balance;
    }

    BankAccount account = new(initialBalance);
    Console.WriteLine($"Account created with initial balance: R{initialBalance:F2}");

    bool exit = false;
    while (!exit)
    {
        Console.WriteLine("\nBank Account Operations:");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Display Balance");
        Console.WriteLine("4. Return to Main Menu");
        Console.Write("Enter your choice (1-4): ");
        
        string? operation = Console.ReadLine();
        
        switch (operation)
        {
            case "1":
                Console.Write("Enter amount to deposit: R");
                if (double.TryParse(Console.ReadLine(), out double depositAmount))
                {
                    account.Deposit(depositAmount);
                    Console.WriteLine($"Deposited: R{depositAmount:F2}");
                    account.DisplayBalance();
                }
                else
                {
                    Console.WriteLine("Invalid amount.");
                }
                break;
                
            case "2":
                Console.Write("Enter amount to withdraw: R");
                if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                {
                    if (account.Withdraw(withdrawAmount))
                    {
                        Console.WriteLine($"Withdrew: R{withdrawAmount:F2}");
                        account.DisplayBalance();
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds.");
                        account.DisplayBalance();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid amount.");
                }
                break;
                
            case "3":
                account.DisplayBalance();
                break;
                
            case "4":
                exit = true;
                Console.WriteLine("Returning to main menu...");
                break;
                
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
    }


}