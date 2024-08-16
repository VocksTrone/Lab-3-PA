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
        public string Type { get; set; }
        public Customers(string name, string email, string address, string type)
        {
            Name = name;
            Email = email;
            Address = address;
            Type = type;
        }
        public virtual double GetDiscount()
        {
            return 0;
        }
        public static int CustomerMenu()
        {
            Console.WriteLine("Tipos de Clientes");
            Console.WriteLine("\n1. Cliente Regular");
            Console.WriteLine("2. Cliente VIP");
            Console.WriteLine("3. Cliente Corporativo");
            Console.Write("\nIngrese una Opción: ");
            int optionCustomerMenu = int.Parse(Console.ReadLine());
            return optionCustomerMenu;
        }
        public static void AddCustomer(ref List<Customers> customersList)
        {
            Console.Write("Nombre del Cliente: ");
            string name = Console.ReadLine();
            Customers customer = customersList.Find(p => p.Name == name);
            if (customer == null)
            {
                Console.Write("Email del Cliente: ");
                string email = Console.ReadLine();
                Console.Write("Dirección del Cliente: ");
                string address = Console.ReadLine();
                CustomerMenu();
                string type = "";
                switch (CustomerMenu())
                {
                    case 1:
                        type = "Cliente Regular";
                        customersList.Add(new RegularCustomer(name, email, address, type));
                        Console.WriteLine("Cliente Añadido con Éxito");
                        Console.ReadKey();
                        break;
                    case 2:
                        type = "Cliente VIP";
                        customersList.Add(new VIPCustomer(name, email, address, type));
                        Console.WriteLine("Cliente Añadido con Éxito");
                        Console.ReadKey();
                        break;
                    case 3:
                        type = "Cliente Corporativo";
                        customersList.Add(new CorporativeCustomer(name, email, address, type));
                        Console.WriteLine("Cliente Añadido con Éxito");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Ingrese una Opción Válida (1 - 3)");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Cliente Existente");
                Console.ReadKey();
            }
        }
        public static void ShowCustomers(ref List<Customers> customersList)
        {
            foreach (var customer in customersList)
            {
                Console.WriteLine($"Nombre: {customer.Name}");
                Console.WriteLine($"Email: {customer.Email}");
                Console.WriteLine($"Dirección: {customer.Address}");
                Console.WriteLine($"Tipo de Cliente: {customer.Type}");
            }
            Console.ReadKey();
        }
        public static void SearchCustomer(ref List<Customers> customersList)
        {
            Console.Write("Nombre del Cliente: ");
            string name = Console.ReadLine();
            Customers customer = customersList.Find(p => p.Name == name);
            if (name != null)
            {
                Console.WriteLine($"Nombre: {customer.Name}");
                Console.WriteLine($"Email: {customer.Email}");
                Console.WriteLine($"Dirección: {customer.Address}");
                Console.WriteLine($"Tipo de Cliente: {customer.Type}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Cliente Inexistente");
                Console.ReadKey();
            }
        }
    }
}