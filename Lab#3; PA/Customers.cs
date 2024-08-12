using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3__PA
{
    public class Customers
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Customers(string name, string email, string address)
        {
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
