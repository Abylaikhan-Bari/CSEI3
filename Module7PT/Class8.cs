using System;

public class Frac
{
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }

    public Frac(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        int gcd = GCD(numerator, denominator);
        Numerator = numerator / gcd;
        Denominator = denominator / gcd;

        if (Denominator < 0)
        {
            Numerator = -Numerator;
            Denominator = -Denominator;
        }
    }

    public static Frac operator +(Frac a, Frac b)
    {
        int newNumerator = (a.Numerator * b.Denominator) + (b.Numerator * a.Denominator);
        int newDenominator = a.Denominator * b.Denominator;
        return new Frac(newNumerator, newDenominator);
    }

    public static Frac operator -(Frac a, Frac b)
    {
        int newNumerator = (a.Numerator * b.Denominator) - (b.Numerator * a.Denominator);
        int newDenominator = a.Denominator * b.Denominator;
        return new Frac(newNumerator, newDenominator);
    }

    public static Frac operator *(Frac a, Frac b)
    {
        int newNumerator = a.Numerator * b.Numerator;
        int newDenominator = a.Denominator * b.Denominator;
        return new Frac(newNumerator, newDenominator);
    }

    public static Frac operator /(Frac a, Frac b)
    {
        if (b.Numerator == 0)
            throw new DivideByZeroException("Division by zero.");
        int newNumerator = a.Numerator * b.Denominator;
        int newDenominator = a.Denominator * b.Numerator;
        return new Frac(newNumerator, newDenominator);
    }

    public static bool operator ==(Frac a, Frac b)
    {
        return (a.Numerator == b.Numerator) && (a.Denominator == b.Denominator);
    }

    public static bool operator !=(Frac a, Frac b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        if (obj is Frac other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Numerator.GetHashCode() ^ Denominator.GetHashCode();
    }

    public override string ToString()
    {
        if (Denominator == 1)
        {
            return Numerator.ToString();
        }
        return $"{Numerator}/{Denominator}";
    }

    private static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }

    public double ToDouble()
    {
        return (double)Numerator / Denominator;
    }
}

public class Polynomial
{
    public Frac[] Coefficients { get; private set; }

    public Polynomial(params Frac[] coefficients)
    {
        Coefficients = coefficients;
    }

    public Frac Evaluate(Frac x)
    {
        Frac result = new Frac(0, 1);
        Frac xPower = new Frac(1, 1);

        foreach (Frac coefficient in Coefficients)
        {
            result += coefficient * xPower;
            xPower *= x;
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        Frac frac1 = new Frac(2, 3);
        Frac frac2 = new Frac(1, 4);

        Frac sum = frac1 + frac2;
        Console.WriteLine("Sum: " + sum);

        Frac difference = frac1 - frac2;
        Console.WriteLine("Difference: " + difference);

        Frac product = frac1 * frac2;
        Console.WriteLine("Product: " + product);

        Frac quotient = frac1 / frac2;
        Console.WriteLine("Quotient: " + quotient);

        Frac frac3 = new Frac(5, 1);

        Console.WriteLine("Frac to Double: " + frac3.ToDouble());

        Frac frac4 = new Frac(3, 4);

        Frac[] coefficients = new Frac[] { frac4, new Frac(2, 1), new Frac(1, 3) };
        Polynomial polynomial = new Polynomial(coefficients);

        Frac x = new Frac(2, 1);
        Frac result = polynomial.Evaluate(x);
        Console.WriteLine($"Polynomial at x = {x}: {result}");
    }
}
