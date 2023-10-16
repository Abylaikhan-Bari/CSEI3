using System;

public class Money
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }

    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public static Money operator +(Money money1, Money money2)
    {
        if (money1.Currency == money2.Currency)
        {
            return new Money(money1.Amount + money2.Amount, money1.Currency);
        }
        else
        {
            throw new InvalidOperationException("Cannot add money in different currencies.");
        }
    }

    public static bool operator ==(Money money1, Money money2)
    {
        return money1.Currency == money2.Currency && money1.Amount == money2.Amount;
    }

    public static bool operator !=(Money money1, Money money2)
    {
        return !(money1 == money2);
    }
}

public class CurrencyConverter
{
    private decimal exchangeRate;

    public CurrencyConverter(decimal rate)
    {
        exchangeRate = rate;
    }

    public Money Convert(Money money, string targetCurrency)
    {
        if (money.Currency == targetCurrency)
        {
            return money; // No conversion needed if it's the same currency.
        }
        else
        {
            // Convert to the target currency.
            if (exchangeRate <= 0)
            {
                throw new InvalidOperationException("Invalid exchange rate.");
            }

            decimal convertedAmount = money.Amount * exchangeRate;
            return new Money(convertedAmount, targetCurrency);
        }
    }
}

class Program
{
    static void Main()
    {
        Money money1 = new Money(100, "USD");
        Money money2 = new Money(200, "USD");

        Money sum = money1 + money2;
        Console.WriteLine("Sum of money1 and money2: " + sum.Amount + " " + sum.Currency);

        CurrencyConverter converter = new CurrencyConverter(0.9m);
        Money convertedMoney = converter.Convert(money1, "EUR");
        Console.WriteLine("Converted money1: " + convertedMoney.Amount + " " + convertedMoney.Currency);

        Money money3 = new Money(100, "EUR");
        bool areEqual = money1 == money3;
        Console.WriteLine("Are money1 and money3 equal? " + areEqual);
    }
}
