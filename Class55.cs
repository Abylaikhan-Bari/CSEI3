using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер трамвайного билета (6-значное число): ");
        string ticketNumber = Console.ReadLine();

        if (ticketNumber.Length != 6)
        {
            Console.WriteLine("Некорректный номер билета. Введите 6-значное число.");
        }
        else
        {
            int sumFirstHalf = 0;
            int sumSecondHalf = 0;

            for (int i = 0; i < 3; i++)
            {
                sumFirstHalf += int.Parse(ticketNumber[i].ToString());
                sumSecondHalf += int.Parse(ticketNumber[i + 3].ToString());
            }

            if (sumFirstHalf == sumSecondHalf)
            {
                Console.WriteLine("Этот билет счастливый!");
            }
            else
            {
                Console.WriteLine("Этот билет не счастливый.");
            }
        }
    }
}
