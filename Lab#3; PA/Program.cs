using Lab_3__PA;
using System.Collections.Generic;

bool generalContinue = true;
List <Customers> customersList = new List <Customers>();
List <Vehicles> vehiclesList = new List <Vehicles>();
List<Orders> ordersList = new List<Orders>();

while (generalContinue)
{
    try
    {
        SwitchFirstMenu();
    }
    catch (FormatException)
    {
        Console.WriteLine("ERROR!, Datos Inválidos");
        Console.ReadKey();
    }
}

bool GoOut()
{
    Console.WriteLine("Usted está Saliendo del Programa");
    generalContinue = false;
    return generalContinue;
}
int FirstMenu()
{
    Console.WriteLine("--- Sistema de Gestión Empresarial 'El Patrón' ---");
    Console.WriteLine("1. Registrar Clientes");
    Console.WriteLine("2. Registrar Vehículos");
    Console.WriteLine("3. Registrar Pedido");
    Console.WriteLine("4. Mostrar Detalles de Clientes");
    Console.WriteLine("5. Mostrar Detalles de Vehículos");
    Console.WriteLine("6. Mostrar Detalles de Pedidos");
    Console.WriteLine("7. Buscar Cliente");
    Console.WriteLine("8. Buscar Vehículo");
    Console.WriteLine("9. Buscar Pedido");
    Console.WriteLine("10. Salir");
    Console.Write("Ingrese una Opción: ");
    int optionFirstMenu = int.Parse(Console.ReadLine());
    return optionFirstMenu;
}
void SwitchFirstMenu()
{
    switch (FirstMenu())
    {
        case 1:
            Customers.AddCustomer(ref customersList);
            break;
        case 2:
            Vehicles.AddVehicle(ref vehiclesList, ref customersList);
            break;
        case 3:
            Orders.AddOrder(ref ordersList, ref customersList);
            break;
        case 4:
            Customers.ShowCustomers(ref customersList);
            break;
        case 5:
            Vehicles.ShowVehicles(ref vehiclesList);
            break;
        case 6:
            Orders.ShowOrders(ref ordersList);
            break;
        case 7:
            Customers.SearchCustomer(ref customersList);
            break;
        case 8:
            Vehicles.SearchVehicles(ref vehiclesList);
            break;
        case 9:
            Orders.SearchOrder(ref ordersList);
            break;
        case 10:
            GoOut();
            break;
        default:
            Console.WriteLine("Ingrese una Opción Válida (1 - 10)");
            Console.ReadKey();
            break;
    }
}
