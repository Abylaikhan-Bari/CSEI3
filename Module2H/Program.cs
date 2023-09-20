using System;

class Program
{
    static void Task1()
    {
        Console.WriteLine("Enter characters followed by a period ('.') to end:");

        char input;
        int spaceCount = 0;


        do
        {
            input = Console.ReadKey().KeyChar;


            if (input == ' ')
            {
                spaceCount++;
            }
        } while (input != '.');

        Console.WriteLine();

        Console.WriteLine($"Number of spaces entered: {spaceCount}");
    }

    static bool Task2(int ticketNumber)
    {

        if (ticketNumber < 100000 || ticketNumber > 999999)
        {
            throw new ArgumentException("Ticket number must be a 6-digit number.");
        }

        int firstThreeDigits = ticketNumber / 1000;
        int lastThreeDigits = ticketNumber % 1000;

        int sumFirstThree = 0;
        int sumLastThree = 0;


        while (firstThreeDigits > 0)
        {
            sumFirstThree += firstThreeDigits % 10;
            firstThreeDigits /= 10;
        }


        while (lastThreeDigits > 0)
        {
            sumLastThree += lastThreeDigits % 10;
            lastThreeDigits /= 10;
        }

        return sumFirstThree == sumLastThree;
    }

    static string Task3(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            char currentChar = charArray[i];


            if (char.IsLower(currentChar))
            {

                charArray[i] = (char)(currentChar - 32);
            }

            else if (char.IsUpper(currentChar))
            {

                charArray[i] = (char)(currentChar + 32);
            }

        }

        return new string(charArray);
    }

    static int Task4(int N)
    {
        int reversedNumber = 0;

        while (N > 0)
        {
            int lastDigit = N % 10;
            reversedNumber = (reversedNumber * 10) + lastDigit;
            N /= 10;
        }

        return reversedNumber;
    }

    static void Task5(int num1, int num2, int num3)
    {
        Console.WriteLine($"{num1}  {num2}  {num3}");
    }

    static void Task6()
    {
        Console.WriteLine("5");
        Console.WriteLine("10");
        Console.WriteLine("21");
    }

    static double CalculateFunction(double x)
    {
        double y = 7 * Math.Pow(x, 2) - 3 * x + 6;
        return y;
    }

    static double CalculateFunction1(double a)
    {
        double x = 12 * Math.Pow(a, 2) + 7 * a - 16;
        return x;
    }

    static double CalculateDistanceToHorizon(double heightAboveEarth)
    {

        double earthRadius = 6350.0;

        double distanceToHorizon = Math.Sqrt(Math.Pow(earthRadius + heightAboveEarth, 2) - Math.Pow(earthRadius, 2));

        return distanceToHorizon;
    }

    static void CalculateMeans(int num1, int num2)
    {

        double arithmeticMean = (num1 + num2) / 2.0;

        double geometricMean = Math.Sqrt(num1 * num2);

        Console.WriteLine($"Arithmetic Mean: {arithmeticMean}");
        Console.WriteLine($"Geometric Mean: {geometricMean}");
    }

    static void ExchangeValues(ref int a, ref int b, ref int c)
    {
        int temp = a;
        a = b;
        b = c;
        c = temp;
    }

    static void CalculateProperties(int number)
    {

        int tens = number / 10;


        int units = number % 10;


        int sum = tens + units;


        int product = tens * units;

        Console.WriteLine($"Number of tens: {tens}");
        Console.WriteLine($"Number of units: {units}");
        Console.WriteLine($"Sum of digits: {sum}");
        Console.WriteLine($"Product of digits: {product}");
    }

    static void CompareNumbers(double number1, double number2)
    {
        if (number1 > number2)
        {
            Console.WriteLine($"{number1} is greater than {number2}");
            Console.WriteLine($"{number2} is smaller than {number1}");
        }
        else if (number2 > number1)
        {
            Console.WriteLine($"{number2} is greater than {number1}");
            Console.WriteLine($"{number1} is smaller than {number2}");
        }
        else
        {
            Console.WriteLine($"{number1} and {number2} are equal");
        }
    }

    static void CompareDistances(double kilometers, double feet)
    {

        double feetInMeters = feet * 0.305;

        if (kilometers < feetInMeters)
        {
            Console.WriteLine($"{kilometers} kilometers is smaller than {feet} feet");
        }
        else if (feetInMeters < kilometers)
        {
            Console.WriteLine($"{feet} feet is smaller than {kilometers} kilometers");
        }
        else
        {
            Console.WriteLine($"{kilometers} kilometers and {feet} feet are equal in length");
        }
    }

    static void CheckNumberProperties(int number)
    {

        bool isEven = number % 2 == 0;


        bool endsWith7 = number % 10 == 7;

        if (isEven)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is not even.");
        }

        if (endsWith7)
        {
            Console.WriteLine($"{number} ends with the digit 7.");
        }
        else
        {
            Console.WriteLine($"{number} does not end with the digit 7.");
        }
    }

    static void AnalyzeTwoDigitNumber(int number)
    {
        if (number >= 10 && number <= 99)
        {

            int tensDigit = number / 10;
            int unitsDigit = number % 10;

            if (tensDigit > unitsDigit)
            {
                Console.WriteLine($"The tens digit ({tensDigit}) is greater than the units digit ({unitsDigit}).");
            }
            else if (unitsDigit > tensDigit)
            {
                Console.WriteLine($"The units digit ({unitsDigit}) is greater than the tens digit ({tensDigit}).");
            }
            else
            {
                Console.WriteLine($"Both digits ({tensDigit} and {unitsDigit}) are the same.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid two-digit number.");
        }
    }

    static bool IsLeapYear(int year)
    {

        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static int GetDaysInMonth(int year, int month)
    {

        int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


        if (IsLeapYear(year) && month == 2)
        {
            return 29;
        }
        else
        {
            return daysInMonth[month];
        }
    }

    static void CalculatePreviousAndNextDay(int year, int month, int day)
    {
        int previousDay, previousMonth, previousYear;
        int nextDay, nextMonth, nextYear;


        if (day == 1)
        {

            previousMonth = (month == 1) ? 12 : month - 1;
            previousYear = (month == 1) ? year - 1 : year;
            previousDay = GetDaysInMonth(previousYear, previousMonth);
        }
        else
        {
            previousDay = day - 1;
            previousMonth = month;
            previousYear = year;
        }


        if (day == GetDaysInMonth(year, month))
        {

            nextMonth = (month == 12) ? 1 : month + 1;
            nextYear = (month == 12) ? year + 1 : year;
            nextDay = 1;
        }
        else
        {
            nextDay = day + 1;
            nextMonth = month;
            nextYear = year;
        }

        Console.WriteLine($"Date of the previous day: {previousYear}-{previousMonth:D2}-{previousDay:D2}");
        Console.WriteLine($"Date of the next day: {nextYear}-{nextMonth:D2}-{nextDay:D2}");
    }

    static void PrintWeightTable()
    {
        Console.WriteLine("Pounds\tKilograms");

        for (int pounds = 1; pounds <= 10; pounds++)
        {
            double kilograms = pounds * 453.0 / 1000.0;
            Console.WriteLine($"{pounds}\t{kilograms:F3}");
        }
    }

    static void PrintMultiplicationTable(int number)
    {
        Console.WriteLine($"Multiplication Table for {number}:");

        for (int i = 1; i <= 9; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
    }

    static void CheckNumberConditions(int number)
    {
        string numberStr = number.ToString();
        int sumOfDigits = 0;
        int productOfDigits = 1;

        bool sumGreaterThan10 = false;
        bool productLessThan50 = true;
        bool evenNumberOfDigits = (numberStr.Length % 2 == 0);
        bool hasFourDigits = (numberStr.Length == 4);
        bool firstDigitNotExceeds6 = (numberStr[0] - '0' <= 6);
        bool beginsAndEndsWithSameDigit = (numberStr[0] == numberStr[numberStr.Length - 1]);
        char firstDigit = numberStr[0];
        char lastDigit = numberStr[numberStr.Length - 1];

        foreach (char digitChar in numberStr)
        {
            int digit = digitChar - '0';
            sumOfDigits += digit;
            productOfDigits *= digit;

            if (digit > 6)
            {
                firstDigitNotExceeds6 = false;
            }
        }

        if (sumOfDigits > 10)
        {
            sumGreaterThan10 = true;
        }

        if (productOfDigits >= 50)
        {
            productLessThan50 = false;
        }

        Console.WriteLine($"a. Sum of digits is greater than 10: {sumGreaterThan10}");
        Console.WriteLine($"b. Product of digits is less than 50: {productLessThan50}");
        Console.WriteLine($"c. Number of digits is an even number: {evenNumberOfDigits}");
        Console.WriteLine($"d. Number has four digits: {hasFourDigits}");
        Console.WriteLine($"e. First digit does not exceed 6: {firstDigitNotExceeds6}");
        Console.WriteLine($"f. Begins and ends with the same digit: {beginsAndEndsWithSameDigit}");
        Console.WriteLine($"g. Greater digit: {((firstDigit > lastDigit) ? firstDigit : lastDigit)}");
    }


    static void Main()
    {
        Console.WriteLine("\nTask 1:");
        Task1();

        Console.WriteLine("\nTask 2:");

        Console.Write("Enter a 6-digit tram ticket number: ");
        int ticketNumber = int.Parse(Console.ReadLine());

        bool isLucky = Task2(ticketNumber);

        if (isLucky)
        {
            Console.WriteLine("This ticket is lucky!");
        }
        else
        {
            Console.WriteLine("This ticket is not lucky.");
        }

        Console.WriteLine("\nTask 3:");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = Task3(input);

        Console.WriteLine("Converted string: " + result);

        Console.Write("Enter an integer: ");
        int inputNumber = int.Parse(Console.ReadLine());

        int reversedResult = Task4(inputNumber);

        Console.WriteLine($"Original number: {inputNumber}");
        Console.WriteLine($"Reversed number: {reversedResult}");

        Console.WriteLine("\nTask 5:");
        int number1 = 10;
        int number2 = 20;
        int number3 = 30;

        Task5(number1, number2, number3);

        Console.WriteLine("\nTask 6:");
        Task6();

        Console.WriteLine("\nTask 7:");
        Console.Write("Enter a value for x: ");
        double x = double.Parse(Console.ReadLine());

        double resultnew = CalculateFunction(x);

        Console.WriteLine($"For x = {x}, y = {resultnew}");

        Console.WriteLine("\nTask 8:");
        Console.Write("Enter a value for a: ");
        double a = double.Parse(Console.ReadLine());

        double result1 = CalculateFunction1(a);

        Console.WriteLine($"For a = {a}, x = {result1}");

        Console.WriteLine("\nTask 9:");
        Console.Write("Enter the height above the Earth's surface (in kilometers): ");
        double height = double.Parse(Console.ReadLine());

        if (height < 0)
        {
            Console.WriteLine("Height cannot be negative.");
        }
        else
        {
            double distance = CalculateDistanceToHorizon(height);

            Console.WriteLine($"Distance to the horizon from {height} km above Earth's surface: {distance} km");
        }
        Console.WriteLine("\nTask 10:");
        Console.Write("Enter the first integer: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = int.Parse(Console.ReadLine());

        CalculateMeans(num1, num2);

        Console.WriteLine("\nTask 11:");
        Console.Write("Enter the value of a: ");
        int a1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        int b1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        int c1 = int.Parse(Console.ReadLine());

        ExchangeValues(ref a1, ref b1, ref c1);

        Console.WriteLine($"After exchanging values: a = {a1}, b = {b1}, c = {c1}");


        Console.WriteLine("\nTask 12:");
        Console.Write("Enter a two-digit number: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 10 && number <= 99)
        {
            CalculateProperties(number);
        }
        else
        {
            Console.WriteLine("Please enter a valid two-digit number.");
        }

        Console.WriteLine("\nTask 13:");
        Console.Write("Enter the first real number: ");
        double numberOne = double.Parse(Console.ReadLine());

        Console.Write("Enter the second real number: ");
        double numberTwo = double.Parse(Console.ReadLine());

        CompareNumbers(numberOne, numberTwo);

        Console.WriteLine("\nTask 14:");
        Console.Write("Enter the distance in kilometers: ");
        double kilometers = double.Parse(Console.ReadLine());

        Console.Write("Enter the distance in feet: ");
        double feet = double.Parse(Console.ReadLine());

        CompareDistances(kilometers, feet);

        Console.WriteLine("\nTask 15:");
        Console.Write("Enter a natural number: ");
        int numberjana = int.Parse(Console.ReadLine());

        if (numberjana >= 0)
        {
            CheckNumberProperties(numberjana);
        }
        else
        {
            Console.WriteLine("Please enter a non-negative natural number.");
        }

        Console.WriteLine("\nTask 16:");
        Console.Write("Enter a two-digit number: ");
        int numberNew = int.Parse(Console.ReadLine());

        AnalyzeTwoDigitNumber(numberNew);

        Console.WriteLine("\nTask 17:");
        Console.Write("Enter the year (g): ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Enter the month (m): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the day (n): ");
        int day = int.Parse(Console.ReadLine());

        CalculatePreviousAndNextDay(year, month, day);

        Console.WriteLine("\nTask 18:");
        Console.WriteLine("Weight Conversion Table (1 pound = 453 grams)");
        PrintWeightTable();

        Console.WriteLine("\nTask 19:");
        int numbernewest = 9;
        PrintMultiplicationTable(numbernewest);


        Console.WriteLine("\nTask 20:");
        Console.Write("Enter a natural number: ");
        int san = int.Parse(Console.ReadLine());

        if (san < 0)
        {
            Console.WriteLine("Please enter a non-negative natural number.");
            return;
        }

        CheckNumberConditions(san);




        Console.ReadKey();
    }
}
