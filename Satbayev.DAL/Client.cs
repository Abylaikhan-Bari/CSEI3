using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.DAL
{
    public class Client
    {
        public int id { get; set; }
        public DateTime CreateDate { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ShortName { get; set; }
        public string FullName
        { get 
            {   
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    return string.Format("{0} {1}.", LastName, FirstName[0]);
                }
                else
                {
                    return string.Format("{0} {1}. {2}.", LastName, FirstName[0], MiddleName[0]);
                }
                
            } 
        }


        public DateTime BirthDay { get; set; }
        public int GetAge {
            get
            {
               return DateTime.Now.Year - BirthDay.Year;
            }
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int IIN { get; set; }
        public Address Adress{ get; set; }

    }
}
