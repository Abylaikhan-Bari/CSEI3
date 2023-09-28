using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a 20-character sequence of letters: ");
        string input = Console.ReadLine().ToUpper(); // Convert to uppercase for case-insensitive comparison

        string name = CreateName(input);

        if (!string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Your name: " + name);
        }
        else
        {
            Console.WriteLine("No name");
        }
    }

    static string CreateName(string sequence)
    {
        // Check if the sequence contains the characters of your name
        if (sequence.Contains("A") && sequence.Contains("B") && sequence.Contains("C") &&
            sequence.Contains("D") && sequence.Contains("E"))
        {
            return "ABCDE"; // Replace with your name
        }

        return null;
    }
}
