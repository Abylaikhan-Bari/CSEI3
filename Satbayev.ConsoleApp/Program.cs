using Satbayev.BLL;
using Satbayev.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.ConsoleApp
{
    internal class Program
    {
        public static string Path = "";
        static void Main(string[] args)
        {
            Console.Write("Enter path to Database: ");
            Path = Console.ReadLine();

            Console.WriteLine("1) - Authorisation");
            Console.WriteLine("2) - Registration");
            ServiceClient service = new ServiceClient(Path);
            string Question = Console.ReadLine();
            if (Question == "1")
            {
                Console.Write("Enter your login: ");
                string login = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                Client client = service.Auth(login, password);
                if (client == null)
                {
                    Console.WriteLine("Your login or password incorrect!!!");
                }
                else
                {
                    Console.WriteLine("Hello " + client.FirstName);
                }

            }
            else if (Question == "2")
            {
                Client client = new Client();
                Console.Write("Enter IIN: ");
                client.IIN = Console.ReadLine();

                Console.Write("Enter Email: ");
                client.Email = Console.ReadLine();

                Console.Write("Enter lastname: ");
                client.FirstName = Console.ReadLine();

                Console.Write("Enter firstname: ");
                client.MiddleName = Console.ReadLine();

                Console.Write("Enter middlename: ");
                client.LastName = Console.ReadLine();

                Console.Write("Enter birth date: ");
                client.BirthDay = DateTime.Parse(Console.ReadLine());
                client.CreateDate = DateTime.Now;
                client.Adress = new Address() { Country = "Kazakstan", City = "Almaty", House = "BigHouse", Region = "Abai", Street = "M.Auezov" };

                service.Registration(client);
            }

        }
    }
}