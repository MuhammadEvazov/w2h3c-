using System;

namespace Task4;

public class BankAccount
{
    private int _accountId;

    private decimal _balance;

    public string OwnerName;

    private bool _isFrozen;

    public BankAccount(int account, decimal balance, string ownerName)
    {
        _accountId = account;
        _balance = balance;
        OwnerName = ownerName;
    }

    

    public void Deposit(decimal amount)
    {
        if (_isFrozen)
            System.Console.WriteLine("The account is freezed");

        if (amount <= 0)
            System.Console.WriteLine("The amount must be positive");

        _balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        if (_isFrozen)
            System.Console.WriteLine("The account is freezed");

        if (amount <= 0)
            System.Console.WriteLine("The amount must be positive");

        if (amount > _balance)
            System.Console.WriteLine($"You don't have enough money");

        _balance -= amount;
    }

    public void FreezeAccount()
    {
        _isFrozen = true;
    }

    public void UnfreezeAccount()
    {
        _isFrozen = false;
    }
}
