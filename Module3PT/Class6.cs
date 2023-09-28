using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text: ");
        string inputText = Console.ReadLine();

        string longestSequence = FindLongestConsecutiveSequence(inputText);

        Console.WriteLine("Longest consecutive sequence of identical characters: " + longestSequence);
    }

    static string FindLongestConsecutiveSequence(string text)
    {
        int maxLength = 0;
        int currentLength = 1;
        char currentChar = text[0];
        char longestChar = currentChar;

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] == currentChar)
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    longestChar = currentChar;
                }
                currentChar = text[i];
                currentLength = 1;
            }
        }

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            longestChar = currentChar;
        }

        string longestSequence = new string(longestChar, maxLength);
        return longestSequence;
    }
}
