using System;

public class BankAccount
{
    public int accountNumberSeed = 1234567890;
    public int accountNumber;
    public string accountHolderName;
    public double balance;

    public BankAccount(string accountHolderName, double initialBalance = 0.0)
    {
        this.accountHolderName = accountHolderName;
        this.balance = initialBalance;
        this.accountNumber = GenerateAccountNumber();
    }

    public int AccountNumber
    {
        get { return accountNumber; }
    }

    public string AccountHolderName
    {
        get { return accountHolderName; }
        set { accountHolderName = value; }
    }

    public double Balance
    {
        get { return balance; }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
        }
    }

    public int GenerateAccountNumber()
    {
        return accountNumberSeed++;
    }
}