using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3__PA
{
    public class Orders
    {
        public int NumOrder { get; set; }
        public DateTime Date { get; set; }
        public Customers Customer { get; set; }
        public List<Products> productsList { get; set; } = new List<Products>();
        public Orders(int numorder, DateTime date, Customers customer)
        {
            NumOrder = numorder;
            Date = date;
            Customer = customer;
        }
        public double GetTotal()
        {
            double total = productsList.Sum(p => p.Price);
            total -= total * Customer.GetDiscount();
            return total;
        }
        public static void AddOrder(ref List<Orders> ordersList, ref List<Customers> customersList)
        {
            Console.Write("Número de Pedido: ");
            int numOrder = int.Parse(Console.ReadLine());
            Orders order = ordersList.Find(p => p.NumOrder == numOrder);
            if (order == null)
            {
                Console.Write("Nombre del Cliente: ");
                string name = Console.ReadLine();
                Customers customer = customersList.Find(p => p.Name == name);
                if (customer != null)
                {
                    Orders addorder = new Orders(numOrder, DateTime.Now, customer);
                    Console.Write("Cantidad de Productos: ");
                    int productsQuantity = int.Parse(Console.ReadLine());
                    for (int i = 0; i < productsQuantity; i++)
                    {
                        Console.Write($"Nombre del Producto No.{i + 1}: ");
                        string nameProduct = Console.ReadLine();
                        Console.Write($"Precio del Producto No.{i + 1}: ");
                        double priceProduct = double.Parse(Console.ReadLine());
                        addorder.productsList.Add(new Products(nameProduct, priceProduct));
                    }
                    ordersList.Add(addorder);
                    Console.WriteLine("Pedido Registrado Correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Cliente Inexistente");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Pedido Duplicado");
                Console.ReadKey();
            }
        }
        public static void ShowOrders(ref List<Orders> ordersList)
        {
            foreach (var order in ordersList)
            {
                Console.WriteLine($"Pedido: No.{order.NumOrder}");
                Console.WriteLine($"Fecha: {order.Date}");
                Console.WriteLine($"Cliente: {order.Customer.Name}");
                Console.WriteLine($"Total: {order.GetTotal()}");
            }
            Console.ReadKey();
        }
        public static void SearchOrder(ref List<Orders> ordersList)
        {
            Console.Write("Número de Pedido: ");
            int numOrder = int.Parse(Console.ReadLine());
            Orders order = ordersList.Find(p => p.NumOrder == numOrder);
            if (order != null)
            {
                Console.WriteLine($"Pedido: No.{order.NumOrder}");
                Console.WriteLine($"Fecha: {order.Date}");
                Console.WriteLine($"Cliente: {order.Customer.Name}");
                Console.WriteLine($"Total: {order.GetTotal()}");
            }
            else
            {
                Console.WriteLine("Pedido Inexistente");
                Console.ReadKey();
            }
        }
    }
}