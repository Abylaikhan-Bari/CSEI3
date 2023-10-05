using System;

public class Calculator
{
    public double Divide(double dividend, double divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }

        return dividend / divisor;
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        try
        {
            Console.Write("Enter dividend: ");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            double result = calculator.Divide(dividend, divisor);
            Console.WriteLine($"Result of division: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }

        Console.WriteLine("Continuing with the program.");
        Console.ReadKey();
    }
}
