using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3__PA
{
    public class RegularCustomer : Customers
    {
        public RegularCustomer(string name, string email, string type, string address) : base (name, email, address, type)
        {
        }
        public override double GetDiscount()
        {
            base.GetDiscount();
            return 0;

        }
    }
}
