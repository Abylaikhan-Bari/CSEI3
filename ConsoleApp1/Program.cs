using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Example01()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Greetings " + name + "!");
            Console.ReadKey();
        }

        static void Example02()
        {
            Console.WriteLine("Enter numbers: ");
            Console.Write("First: ");
            string strFirst = Console.ReadLine();
            Console.Write("Second: ");
            string strSecond = Console.ReadLine();

            int first;
            int second;

            
            while (!Int32.TryParse(strFirst, out first) || !Int32.TryParse(strSecond, out second))
            {
                Console.WriteLine("Enter correct data!");
                Console.Write("First: ");
                strFirst = Console.ReadLine();
                Console.Write("Second: ");
                strSecond = Console.ReadLine();
            }

            int sum = first + second;
            Console.WriteLine("Sum of numbers: " + sum);

            Console.ReadKey();
        }

        static void Example03()
        {
            Console.Write("Enter your year of born:");
            string strYear = Console.ReadLine();
            int year = 0;


            year = Convert.ToInt32(strYear);

            //year = Int32.Parse(strYear);

            bool result = Int32.TryParse(strYear, out year);

            if (result == false)
            {
                Console.WriteLine("Enter correct data!");
            }

            //else
            //{
            //    Console.WriteLine(result);
            //}

        }
        static void Example04(int x)
        {
            x = x + 1;
        }

        static void Example05(User user)
        {
            user.Age = user.Age + 1;
        }

        static void Main(string[] args)
        {
            ////Console.WriteLine("Choose action: ");
            //int a = 1;
            //int b = 2;
            //Console.ReadLine();

            //Example01();
            Example02();


            //int a = 20;
            //Example04(a);
            //Console.WriteLine("a:" + a);

            //User user = new User();
            //user.Age = a;
            //Example05(user);
            //Console.WriteLine("Age: " + user.Age);
            //Console.ReadKey();


        }
    }

    public class User
    {
        public int Age { get; set; }
    }
}
