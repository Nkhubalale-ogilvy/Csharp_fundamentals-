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
        Console.WriteLine($"Current Balance: ${_accountBalance:F2}");
    }
}