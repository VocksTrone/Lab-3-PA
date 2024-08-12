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
        public RegularCustomer(string name, string email, string address) : base (name, email, address)
        {
        }
    }
}
