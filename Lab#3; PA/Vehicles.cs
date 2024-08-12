using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3__PA
{
    public class Vehicles
    {
        public string Plate { get; set; }
        public string Model { get; set; }
        public string Fuel { get; set; }
        public Vehicles(string plate, string model, string fuel)
        {
            Plate = plate;
            Model = model;
            Fuel = fuel;
        }
    }
}
