using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3__PA
{
    public class CorporativeCustomer : Customers
    {
        public List<CorporativeVehicle> Vehicles { get; set; } = new List<CorporativeVehicle>();
        public CorporativeCustomer(string name, string email, string address, string type) : base (name, email, address, type)
        {
        }
        public override double GetDiscount()
        {
            base.GetDiscount();
            return 0.20;
        }
    }
}
