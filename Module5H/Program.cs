using System;

class Program
{
    static void Main()
    {
        try
        {
            // Call the method that generates an exception
            CallMethodWithException();
        }
        catch (CustomException ex)
        {
            // Handle the custom exception raised by the called method
            Console.WriteLine($"Caught custom exception: {ex.Message}");
        }

        Console.WriteLine("Program completed.");
        Console.ReadKey();
    }

    static void CallMethodWithException()
    {
        // Call the method that generates an exception
        MethodWithException();
    }

    static void MethodWithException()
    {
        // Generate a custom exception
        throw new CustomException("This is a custom exception1.");
    }
}

// Define a custom exception class
class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}
