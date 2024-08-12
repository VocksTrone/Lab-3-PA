using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3__PA
{
    public class CorporativeCustomer : Customers
    {
        public double AditionalDiscount { get; set; }
        public int AsociatedVehicle { get; set; }
        public CorporativeCustomer(string name, string email, string address, double aditionaldiscount, int asociatedvehicle) : base (name, email, address)
        {
            AditionalDiscount = aditionaldiscount;
            AsociatedVehicle = asociatedvehicle;
        }
    }
}
