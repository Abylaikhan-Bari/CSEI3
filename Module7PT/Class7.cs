using System;

public struct Complex
{
    public double Real { get; }
    public double Imaginary { get; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }

    public static Complex operator *(Complex a, Complex b)
    {
        double real = (a.Real * b.Real) - (a.Imaginary * b.Imaginary);
        double imaginary = (a.Real * b.Imaginary) + (a.Imaginary * b.Real);
        return new Complex(real, imaginary);
    }

    public static Complex operator /(Complex a, Complex b)
    {
        double denominator = (b.Real * b.Real) + (b.Imaginary * b.Imaginary);
        if (denominator == 0)
            throw new DivideByZeroException("Division by zero.");
        double real = ((a.Real * b.Real) + (a.Imaginary * b.Imaginary)) / denominator;
        double imaginary = ((a.Imaginary * b.Real) - (a.Real * b.Imaginary)) / denominator;
        return new Complex(real, imaginary);
    }

    public static bool operator ==(Complex a, Complex b)
    {
        return (a.Real == b.Real) && (a.Imaginary == b.Imaginary);
    }

    public static bool operator !=(Complex a, Complex b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        if (obj is Complex other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Real.GetHashCode() ^ Imaginary.GetHashCode();
    }

    public override string ToString()
    {
        return $"({Real}, {Imaginary}i)";
    }

    public static implicit operator Complex(double real)
    {
        return new Complex(real, 0);
    }
}

class Program
{
    static void Main()
    {
        Complex complex1 = new Complex(2, 3);
        Complex complex2 = new Complex(1, 4);

        Complex sum = complex1 + complex2;
        Console.WriteLine("Sum: " + sum);

        Complex difference = complex1 - complex2;
        Console.WriteLine("Difference: " + difference);

        Complex product = complex1 * complex2;
        Console.WriteLine("Product: " + product);

        Complex quotient = complex1 / complex2;
        Console.WriteLine("Quotient: " + quotient);

        Complex complex3 = 5.0; // Implicit type conversion from double
        Console.WriteLine("Implicit conversion: " + complex3);

        // Comparison
        Console.WriteLine("Equality: " + (complex1 == complex2));
        Console.WriteLine("Inequality: " + (complex1 != complex2));
    }
}
