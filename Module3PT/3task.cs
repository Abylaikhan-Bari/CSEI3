using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The input string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The input string is not a palindrome.");
        }
    }

    static bool IsPalindrome(string input)
    {
        // Remove spaces and convert to lowercase for case-insensitive comparison
        input = input.Replace(" ", "").ToLower();

        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
