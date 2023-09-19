using System;

class Program
{
    static void Main(string[] args)
    {
        Task1();
        Console.WriteLine();
        Task2();
        Console.WriteLine();
        Task3();
        Console.WriteLine();
        Task4();
        Console.WriteLine();
        Task5();
        Console.WriteLine();
        Task6();
        Console.WriteLine();
        Task7();
        Console.WriteLine();
        Task8();
        Console.WriteLine();
        Task9();
        Console.WriteLine();
        //Task10();
        Console.WriteLine();
        //Task11();
        Console.WriteLine();
        Task12();
        Console.WriteLine();
        Task13();
        Console.WriteLine();
        Task16();
        Console.WriteLine();
        //Task17();
        Console.WriteLine();
        //Task18();
        Console.WriteLine("Task 19:");
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine($"Before swap: num1 = {num1}, num2 = {num2}");

        
        Task19(ref num1, ref num2);

        Console.WriteLine($"After swap: num1 = {num1}, num2 = {num2}");
        Console.WriteLine();


        Console.WriteLine("Task 20:");
        int san1 = 5;
        int san2 = 10;

        Console.WriteLine($"Before swap: san1 = {san1}, san2 = {san2}");

        
        Task20(ref san1, ref san2);

        Console.WriteLine($"After swap: san1 = {san1}, san2 = {san2}");
        Console.WriteLine();

        Console.WriteLine("Task 22:");
        int result1 = Task22(0, 0); 
        int result2 = Task22(4, 0); 
        int result3 = Task22(0, 6); 
        int result4 = Task22(3, 4); 

        Console.WriteLine($"Result 1: {result1}");
        Console.WriteLine($"Result 2: {result2}");
        Console.WriteLine($"Result 3: {result3}");
        Console.WriteLine($"Result 4: {result4}");
        Console.WriteLine();

        Console.WriteLine("Task 23:");
        int hours = 7;
        int minutes = 30;
        int seconds = 45;

        int result = Task23(hours, minutes, seconds);

        Console.WriteLine($"Number of seconds since the start of the day: {result}");
        Console.WriteLine();

        Console.WriteLine("Task 24:");
        int month = 3;
        int day = 15;

        
        int resultnew = Task24(month, day);

        Console.WriteLine($"Number of days since the beginning of the year: {resultnew}");
        Console.WriteLine();

        Console.WriteLine("Task 25:");

        int monthnew = 3;
        int daynew = 15;

        
        int resultnew1 = Task25(month, day);

        Console.WriteLine($"Number of days since the beginning of the year: {resultnew1}");
        Console.WriteLine();


        Console.WriteLine("Task 26:");
        int result1new = Task26(5);               
        int result2new = Task26(8, 3);            
        int result3new = Task26(7, 15, 4);        

        Console.WriteLine($"Smallest: {result1new}");
        Console.WriteLine($"Smallest: {result2new}");
        Console.WriteLine($"Smallest: {result3new}");

        Console.WriteLine();

        Console.WriteLine("Task 27:");
        int number1 = 6;
        int number2 = 7;

        bool isEven1 = Task27(number1);
        bool isEven2 = Task27(number2);

        Console.WriteLine($"{number1} is even: {isEven1}");
        Console.WriteLine($"{number2} is even: {isEven2}");
        Console.WriteLine();


        //Console.WriteLine("Task 28:");
        //Console.WriteLine("Enter three integers:");

        
        //int numnew1 = int.Parse(Console.ReadLine());
        //int numnew2 = int.Parse(Console.ReadLine());
        //int numnew3 = int.Parse(Console.ReadLine());

        
        //int newresult = Task28(numnew1, numnew2, numnew3);

        //Console.WriteLine($"The smallest number is: {newresult}");
        Console.WriteLine();

        Console.WriteLine("Task 29:");
        string newresult1 = Task29();

        Console.WriteLine($"Result: {newresult1}");
        Console.WriteLine();

        Console.WriteLine("Task 30:");
        int M = 5;
        int N = 15;

        
        int newestresult = Task30(M, N);

        Console.WriteLine($"Sum of odd numbers between {M} and {N}: {newestresult}");
        Console.WriteLine();

        Console.WriteLine("Task 31:");
        int N1 = 15;
        int n1 = 3;

        // Call the Task31 method to calculate the smallest multiple of n greater than or equal to N
        int resultone = Task31(N1, n1);

        Console.WriteLine($"The smallest multiple of {n1} greater than or equal to {N1} is: {resultone}");
        Console.WriteLine();

        Console.ReadKey();
    }

    static void Task1()
    {
        int num1 = 10;
        int num2 = 20;
        int num3 = 30;
        Console.WriteLine("Task 1:");
        Console.WriteLine($"{num1}  {num2}  {num3}");
    }
    static void Task2()
    {
        int num1 = 5;
        int num2 = 10;
        int num3 = 21;
        Console.WriteLine("Task 2:");
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
    }
    static void Task3()
    {
        int distanceInCentimeters = 250;

        int meters = distanceInCentimeters / 100;

        Console.WriteLine("Task 3:");
        Console.WriteLine($"Centimetres: {distanceInCentimeters}");
        Console.WriteLine($"The number of full meters is: {meters}");
    }
    static void Task4()
    {
        int days = 234;
        int weeks = days / 7;
        Console.WriteLine("Task 4:");
        Console.WriteLine($"The number of full weeks that have passed is: {weeks}");
    }
    static void Task5()
    {
        int number = 47;

        int tens = number / 10;

        int units = number % 10;


        int sum = tens + units;


        int product = tens * units;

        Console.WriteLine("Task 5:");
        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"a. Number of tens: {tens}");
        Console.WriteLine($"b. Number of units: {units}");
        Console.WriteLine($"c. Sum of its digits: {sum}");
        Console.WriteLine($"d. Product of its digits: {product}");
    }
    static void Task6()
    {
        bool A = true;
        bool B = false;
        bool C = false;

        bool resultA = A || B;

        bool resultB = A && B;

        bool resultC = B || C;

        Console.WriteLine("Task 6:");
        Console.WriteLine($"a. A or B: {resultA}");
        Console.WriteLine($"b. A and B: {resultB}");
        Console.WriteLine($"c. B or C: {resultC}");
    }
    static void Task7()
    {
        double circleRadius = 5.0;
        double squareSideLength = 6.0;
        double circleArea = Math.PI * circleRadius * circleRadius;


        double squareArea = squareSideLength * squareSideLength;

        string largestFigure;

        if (circleArea > squareArea)
        {
            largestFigure = "Circle";
        }
        else if (circleArea < squareArea)
        {
            largestFigure = "Square";
        }
        else
        {
            largestFigure = "Both the circle and square have the same area";
        }

        Console.WriteLine("Task 7:");
        Console.WriteLine($"The radius of the Circle is {circleRadius}");
        Console.WriteLine($"The side length of the Square is {squareSideLength}");
        Console.WriteLine($"The area of the Circle is {circleArea}");
        Console.WriteLine($"The area of the Square is {squareArea}");
        Console.WriteLine($"The figure with the largest area is: {largestFigure}");
    }


    static void Task8()
    {
        double volume1 = 10.0;
        double mass1 = 50.0;
        double volume2 = 15.0;
        double mass2 = 75.0;

        double density1 = mass1 / volume1;


        double density2 = mass2 / volume2;

        string highestDensityMaterial;

        if (density1 > density2)
        {
            highestDensityMaterial = "Material of Body 1";
        }
        else if (density1 < density2)
        {
            highestDensityMaterial = "Material of Body 2";
        }
        else
        {
            highestDensityMaterial = "Both materials have the same density";
        }

        Console.WriteLine("Task 8:");
        Console.WriteLine($"Density of Material of Body 1: {density1}");
        Console.WriteLine($"Density of Material of Body 2: {density2}");
        Console.WriteLine($"The material with the highest density is: {highestDensityMaterial}");
    }
    static void Task9()
    {
        double voltage1 = 12.0;
        double resistance1 = 4.0;
        double voltage2 = 9.0;
        double resistance2 = 3.0;

        double current1 = voltage1 / resistance1;

        double current2 = voltage2 / resistance2;

        string leastCurrentArea;

        if (current1 < current2)
        {
            leastCurrentArea = "First Section";
        }
        else if (current1 > current2)
        {
            leastCurrentArea = "Second Section";
        }
        else
        {
            leastCurrentArea = "Both sections have the same current";
        }

        Console.WriteLine("Task 9:");
        Console.WriteLine($"Current in First Section: {current1} A");
        Console.WriteLine($"Current in Second Section: {current2} A");
        Console.WriteLine($"The area with the least current is: {leastCurrentArea}");
    }

    static void Task10()
    {
        Console.WriteLine("Task 10:");

        Console.WriteLine("a. All integers from 20 to 35:");
        for (int i = 20; i <= 35; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();


        Console.Write("b. Enter a value for 'b' (greater than 10): ");
        int b = int.Parse(Console.ReadLine());
        if (b > 10)
        {
            Console.WriteLine($"Squares of integers from 10 to {b}:");
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine($"{i}^2 = {i * i}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for 'b'. Please enter a value greater than 10.");
        }

        Console.WriteLine();


        Console.Write("c. Enter a value for 'a' (less than 50): ");
        int a = int.Parse(Console.ReadLine());
        if (a < 50)
        {
            Console.WriteLine($"Third powers of integers from {a} to 50:");
            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine($"{i}^3 = {i * i * i}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for 'a'. Please enter a value less than 50.");
        }

        Console.WriteLine();

        Console.Write("d. Enter a value for 'a': ");
        int inputA = int.Parse(Console.ReadLine());
        Console.Write("   Enter a value for 'b' (greater than 'a'): ");
        int inputB = int.Parse(Console.ReadLine());

        Console.WriteLine($"All integers from {inputA} to {inputB}:");
        for (int i = inputA; i <= inputB; i++)
        {
            Console.WriteLine(i);
        }
    }

    static double Task11()
    {
        Console.WriteLine("Task 11:");
        Console.Write("Enter a value for x: ");
        double x = double.Parse(Console.ReadLine());
        double y = 2 * x * x + 3 * x + 1;


        Console.WriteLine($"For x = {x}, y = {y}");



        return y;
    }

    static void Task12()
    {
        double radius = 5.0;

        double circumference = 2 * Math.PI * radius;


        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("Task 12:");
        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Circumference: {circumference}");
        Console.WriteLine($"Area: {area}");
    }

    static void Task13()
    {
        int distanceInCentimeters = 250;

        double distanceInMeters = distanceInCentimeters * 0.01;


        int fullMeters = (int)distanceInMeters;

        Console.WriteLine("Task 13:");
        Console.WriteLine($"Distance in centimeters: {distanceInCentimeters} cm");
        Console.WriteLine($"Number of full meters: {fullMeters} meters");
    }

    static void Task16()
    {
        int number = 1234;
        
        int thousands = number / 1000;
        int hundreds = (number / 100) % 10;
        int tens = (number / 10) % 10;
        int units = number % 10;

        
        int sum = thousands + hundreds + tens + units;

        
        int product = thousands * hundreds * tens * units;

        Console.WriteLine("Task 16:");
        Console.WriteLine($"a. Sum of its digits: {sum}");
        Console.WriteLine($"b. Product of its digits: {product}");
    }

    static void Task17()
    {
        Console.WriteLine("Task 17:");

        for (int x = 100; x < 1000; x++)
        {
            int firstDigit = x / 100;
            int thirdDigit = x % 10;

            int twoDigitNumber = (firstDigit * 10) + thirdDigit;

            
            if (twoDigitNumber + (x / 10) == 456)
            {
                Console.WriteLine($"The number x is: {x}");
                break; 
            }
        }
    }

    //static void Task18()
    //{
    //    Console.WriteLine("Truth Table:");
    //    Console.WriteLine("X     Y     not X and not Y    X or (not X and Y)   (not X and Y) or Y");

    //    // Loop through all possible values of X (true and false)
    //    for (bool X = false; X <= true; X = !X)
    //    {
    //        // Loop through all possible values of Y (true and false)
    //        for (bool Y = false; Y <= true; Y = !Y)
    //        {
    //            // Calculate the values of the logical expressions
    //            bool resultA = !X && !Y;
    //            bool resultB = X || (!X && Y);
    //            bool resultC = (!X && Y) || Y;

    //            // Display the truth values in the table
    //            Console.WriteLine($"{X}     {Y}     {resultA}                {resultB}                {resultC}");
    //        }
    //    }
    //}

    static void Task19(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;

    }

    static void Task20(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static int Task22(int x, int y)
    {
        if (x == 0 && y == 0)
        {
            return 0;
        }
        else if (y == 0)
        {
            return 12 / x;
        }
        else if (x == 0)
        {
            return 12 / y;
        }
        else
        {
            return 144 / (x * y);
        }
    }

    static int Task23(int h, int m, int s)
    {
        
        int totalSeconds = (h * 3600) + (m * 60) + s;

        return totalSeconds;
    }

    static int Task24(int m, int d)
    {
        
        if (m < 1 || m > 12 || d < 1 || d > 30)
        {
            throw new ArgumentException("Invalid month or day.");
        }

        
        int totalDays = (m - 1) * 30 + d;

        return totalDays;
    }

    static int Task25(int m, int d)
    {
        
        if (m < 1 || m > 12 || d < 1 || d > 31)
        {
            throw new ArgumentException("Invalid month or day.");
        }

        
        int[] daysInMonth = { 31, 30, 31, 30, 31, 31, 30, 31, 30, 31, 30, 31 };

        
        int totalDays = 0;

        for (int i = 0; i < m - 1; i++)
        {
            totalDays += daysInMonth[i];
        }

        totalDays += d;

        return totalDays;
    }

    static int Task26(int m1 = 999, int m2 = 999, int m3 = 999)
    {
        int smallest = m1;

        if (m2 < smallest)
        {
            smallest = m2;
        }

        if (m3 < smallest)
        {
            smallest = m3;
        }

        return smallest;
    }


    static bool Task27(int n)
    {
        
        return n % 2 == 0;
    }

    static int Task28(int num1, int num2, int num3)
    {
        int smallest;

        
        if (num1 <= num2 && num1 <= num3)
        {
            smallest = num1;
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            smallest = num2;
        }
        else
        {
            smallest = num3;
        }

        return smallest;
    }

    static string Task29()
    {
        
        Random random = new Random();

        
        int score = random.Next(2, 6);

        string result;

        
        switch (score)
        {
            case 2:
                result = "Fail";
                break;
            case 3:
                result = "Pass";
                break;
            case 4:
                result = "Good";
                break;
            case 5:
                result = "Excellent";
                break;
            default:
                result = "Invalid Score";
                break;
        }

        return result;
    }

    static int Task30(int M, int N)
    {
        int sum = 0;

        
        if (M > N)
        {
            int temp = M;
            M = N;
            N = temp;
        }

        
        for (int i = M; i <= N; i++)
        {
            
            if (i % 2 != 0)
            {
                sum += i; 
            }
        }

        return sum;
    }


    static int Task31(int N, int n)
    {
        
        if (n <= 0)
        {
            throw new ArgumentException("n must be a positive integer.");
        }

        int result = N;

        
        while (result % n != 0)
        {
            result++;
        }

        return result;
    }

}
