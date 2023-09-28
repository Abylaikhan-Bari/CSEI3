using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a lowercase Russian letter: ");
        char input = Console.ReadLine()[0]; // Read the first character entered

        char uppercaseLetter = ConvertToLowercaseToUppercase(input);

        Console.WriteLine("Uppercase equivalent: " + uppercaseLetter);
    }

    static char ConvertToLowercaseToUppercase(char lowercaseLetter)
    {
        if (char.IsLower(lowercaseLetter) && lowercaseLetter >= 'а' && lowercaseLetter <= 'я')
        {
            // Convert lowercase Russian letter to uppercase using ASCII values
            return (char)(lowercaseLetter - 'а' + 'А');
        }
        else
        {
            return lowercaseLetter; // Return the input character if it's not a lowercase Russian letter
        }
    }
}
