using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();

        int lastIndexC = sentence.LastIndexOf('с');
        int lastIndexT = sentence.LastIndexOf('Т');

        if (lastIndexC > lastIndexT)
        {
            Console.WriteLine("Буква 'с' встречается позже.");
        }
        else if (lastIndexC < lastIndexT)
        {
            Console.WriteLine("Буква 'Т' встречается позже.");
        }
        else
        {
            Console.WriteLine("Буквы 'с' и 'Т' встречаются в одном и том же месте.");
        }
    }
}
