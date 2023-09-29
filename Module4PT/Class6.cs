using System;
using System.Collections.Generic;

class BankAccount
{
    public int AccountNumber { get; }
    public decimal Balance { get; private set; }

    public BankAccount(int accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} to Account {AccountNumber}. New balance: {Balance:C}");
        }
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C} from Account {AccountNumber}. New balance: {Balance:C}");
            return true;
        }
        Console.WriteLine($"Insufficient balance in Account {AccountNumber}. Withdrawal failed.");
        return false;
    }
}

class BankCard
{
    public int CardNumber { get; }
    public bool IsBlocked { get; private set; }

    public BankCard(int cardNumber)
    {
        CardNumber = cardNumber;
        IsBlocked = false;
    }

    public void BlockCard()
    {
        IsBlocked = true;
        Console.WriteLine($"Card {CardNumber} has been blocked.");
    }
}

class Client
{
    public string Name { get; }
    public BankAccount Account { get; }
    public BankCard Card { get; }

    public Client(string name, int accountNumber, int cardNumber, decimal initialBalance)
    {
        Name = name;
        Account = new BankAccount(accountNumber, initialBalance);
        Card = new BankCard(cardNumber);
    }

    public void MakePayment(decimal amount)
    {
        if (!Card.IsBlocked)
        {
            if (Account.Withdraw(amount))
            {
                Console.WriteLine($"Payment of {amount:C} made from Account {Account.AccountNumber} using Card {Card.CardNumber}");
            }
        }
        else
        {
            Console.WriteLine($"Card {Card.CardNumber} is blocked. Payment failed.");
        }
    }
}

class Administrator
{
    public void BlockCard(BankCard card)
    {
        card.BlockCard();
    }
}

class Program
{
    static void Main()
    {
        Client client1 = new Client("John", 101, 201, 1000.00m);
        Client client2 = new Client("Alice", 102, 202, 1500.00m);

        Administrator admin = new Administrator();

        Console.WriteLine("Initial Account Balances:");
        Console.WriteLine($"{client1.Name}'s Account: {client1.Account.Balance:C}");
        Console.WriteLine($"{client2.Name}'s Account: {client2.Account.Balance:C}");

        Console.WriteLine("\nMaking Payments:");
        client1.MakePayment(500.00m);
        client2.MakePayment(2000.00m); // Should fail due to insufficient balance

        Console.WriteLine("\nBlocking Card:");
        admin.BlockCard(client1.Card);

        Console.WriteLine("\nAttempting Payment with Blocked Card:");
        client1.MakePayment(200.00m); // Should fail due to blocked card
    }
}
