using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.DAL
{
    internal class Account
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int ClientId { get; set; }
        public string IBAN { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int Currency { get; set; }

        private double _Balance;
        public double Balance {
            get
            {
                return _Balance;
            }
            set
            {
                if (value < 0)
                {
                    _Balance = 0;
                }
                else
                {
                    _Balance =  value;
                }
            }
            }

        public bool IsActive { get; set; } = true;
        public bool CanPayOnline { get; set; } = false;


    }
}
