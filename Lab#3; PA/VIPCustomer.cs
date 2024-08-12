using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3__PA
{
    public class VIPCustomer : Customers
    {
        public double SpecialDiscount { get; set; }
        public VIPCustomer(string name, string email, string address, double specialDiscount) : base (name, email, address)
        {
            SpecialDiscount = specialDiscount;
        }
    }
}
