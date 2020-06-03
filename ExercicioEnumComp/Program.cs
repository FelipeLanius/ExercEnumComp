using ExercicioEnumComp.Entities;
using ExercicioEnumComp.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioEnumComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
      
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter Order Data:");
            DateTime moment = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(moment, status, client);
            

            Console.WriteLine("How many items to this order?");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(nameProduct, priceProduct);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, priceProduct, product);
                order.AddItem(orderItem);

                
            }
            Console.WriteLine();
            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order);
            
        }
    }
}
