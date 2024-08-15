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
        public string Type { get; set; }
        public Vehicles(string plate, string model, string fuel, string type)
        {
            Plate = plate;
            Model = model;
            Fuel = fuel;
            Type = type;
        }
        public static int VehicleMenu()
        {
            Console.WriteLine("Tipos de Vehículos");
            Console.WriteLine("\n1. Vehículo Personal");
            Console.WriteLine("2. Vehículo Corporativo");
            Console.Write("\nIngrese una Opción: ");
            int optionVehicleMenu = int.Parse(Console.ReadLine());
            return optionVehicleMenu;
        }
        public static void AddVehicle(ref List<Vehicles> vehiclesList, ref List<Customers> customersList)
        {
            Console.Write("Placa del Vehículo: ");
            string plate = Console.ReadLine();
            Vehicles vehicle = vehiclesList.Find(p => p.Plate == plate);
            if (vehicle == null)
            {
                Console.Write("Modelo del Vehículo: ");
                string model = Console.ReadLine();
                Console.Write("Tipo de Gasolina del Vehículo: ");
                string fuel = Console.ReadLine();
                VehicleMenu();
                string type = "";
                switch (VehicleMenu())
                {
                    case 1:
                        type = "Vehículo Personal";
                        vehiclesList.Add(new PersonalVehicle(plate, model, fuel, type));
                        Console.WriteLine("Vehículo Añadido con Éxito");
                        Console.ReadKey();
                        break;
                    case 2:
                        type = "Vehículo Corporativo";
                        Console.Write("Cliente Corporativo Asociado: ");
                        string corpCustomer = Console.ReadLine();
                        CorporativeCustomer customer = customersList.OfType<CorporativeCustomer>().FirstOrDefault(p => p.Name == corpCustomer);
                        if (customer != null)
                        {
                            var addvehicle = new CorporativeVehicle(plate, model, fuel, type);
                            vehiclesList.Add(addvehicle);
                            customer.Vehicles.Add(addvehicle);
                            Console.WriteLine("Vehículo Añadido con Éxito");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Cliente Inexistente");
                            Console.ReadKey();
                        }
                        break;
                    default:
                        Console.WriteLine("Ingrese una Opción Válida (1 - 3)");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Placa Existente");
                Console.ReadKey();
            }
        }
        public static void ShowVehicles(ref List<Vehicles> vehiclesList)
        {
            foreach (var vehicle in vehiclesList)
            {
                Console.WriteLine($"Placa: {vehicle.Plate}");
                Console.WriteLine($"Modelo: {vehicle.Model}");
                Console.WriteLine($"Tipo de Combustible: {vehicle.Fuel}");
                Console.WriteLine($"Tipo de Vehículo: {vehicle.Type}");
            }
            Console.ReadKey();
        }
        public static void SearchVehicles(ref List<Vehicles> vehiclesList)
        {
            Console.Write("Placa del Vehículo: ");
            string plate = Console.ReadLine();
            Vehicles vehicle = vehiclesList.Find(p => p.Plate == plate);
            if (vehicle != null)
            {
                Console.WriteLine($"Placa: {vehicle.Plate}");
                Console.WriteLine($"Modelo: {vehicle.Model}");
                Console.WriteLine($"Tipo de Combustible: {vehicle.Fuel}");
                Console.WriteLine($"Tipo de Vehículo: {vehicle.Type}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Vehículo Inexistente");
                Console.ReadKey();
            }
        }
    }
}
