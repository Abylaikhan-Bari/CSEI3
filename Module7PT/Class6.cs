using System;

public class Decimal
{
    private char[] digits;

    public Decimal()
    {
        // Initialize to zero
        digits = new char[100];
        Array.Fill(digits, '0');
    }

    public Decimal(string value)
    {
        // Initialize from a string representation
        if (value.Length > 100)
        {
            throw new ArgumentException("Value exceeds maximum length.");
        }

        digits = new char[100];
        for (int i = 0; i < value.Length; i++)
        {
            if (Char.IsDigit(value[i]))
            {
                digits[100 - value.Length + i] = value[i];
            }
            else
            {
                throw new ArgumentException("Invalid character in value.");
            }
        }
    }

    public override string ToString()
    {
        // Convert to a string representation
        int startIndex = Array.IndexOf(digits, '1');
        return new string(digits, startIndex, 100 - startIndex);
    }

    public static Decimal operator +(Decimal left, Decimal right)
    {
        // Add two Decimal instances
        // Implement your addition logic here
        return new Decimal();
    }

    public static Decimal operator -(Decimal left, Decimal right)
    {
        // Subtract two Decimal instances
        // Implement your subtraction logic here
        return new Decimal();
    }

    public static Decimal operator *(Decimal left, Decimal right)
    {
        // Multiply two Decimal instances
        // Implement your multiplication logic here
        return new Decimal();
    }

    public static Decimal operator /(Decimal left, Decimal right)
    {
        // Divide two Decimal instances
        // Implement your division logic here
        return new Decimal();
    }
}

class Program
{
    static void Main()
    {
        Decimal number1 = new Decimal("1234567890");
        Decimal number2 = new Decimal("9876543210");

        Decimal sum = number1 + number2;
        Console.WriteLine("Sum: " + sum);

        Decimal difference = number2 - number1;
        Console.WriteLine("Difference: " + difference);

        Decimal product = number1 * number2;
        Console.WriteLine("Product: " + product);

        Decimal quotient = number2 / number1;
        Console.WriteLine("Quotient: " + quotient);
    }
}
