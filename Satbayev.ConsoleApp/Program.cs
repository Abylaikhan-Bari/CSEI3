using Satbayev.BLL;
using Satbayev.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.ConsoleApp
{
    internal class Program
    {
        public static string Path = "";
        //{ get
        //    { 

        //        return "";
        //    }
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path to your Database");
            Path = Console.ReadLine();

            ServiceClient service = new ServiceClient(Path);
            Client client = new Client();
            client.IIN = 021206500613;
            client.Email = "abylaikhanbariev7@gmail.com";
            client.FirstName = "Abylaikhan";
            client.LastName = "Bari";
            client.MiddleName = "Askarbekuly";
            client.BirthDay = new DateTime(2002, 06, 12);
            client.Adress = new Address() { Country = "Kazakhstan", Region = "Almaty", City = "Almaty city", PostalCode = "115002", Street = "Abay 25", } ;

            service.Registration(client);
        }
    }
}
