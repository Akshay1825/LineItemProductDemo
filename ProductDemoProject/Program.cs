using ProductDemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Television", 25000, 10);
            Product product2 = new Product(2, "Cooler", 6000, 5);

            LineItem lineItem1 = new LineItem(1, 2, product1);
            LineItem lineItem2 = new LineItem(2, 3, product2);

            Order order1 = new Order(1, DateTime.Now);
            order1.items.Add(lineItem1);
            order1.items.Add(lineItem2);

            Customer customer1 = new Customer(1, "Yogesh");
            customer1.Orders.Add(order1);

            Console.WriteLine($"Customer: {customer1.Name}\n");

            Console.WriteLine($"Order ID: {order1.Id}, Date :  {order1.Date}\n");

            Console.WriteLine($"Product 1: {product1.Name}\n" +
                $"Quantity: {lineItem1.Quantity}\n" +
                $"Price per unit (Before discount): {product1.Price}\n" +
                $"Price per unit (after discount): {product1.CalculateDiscountedPrice()}\n");

            Console.WriteLine($"Product 2: {product2.Name}\n" +
                $"Quantity: {lineItem2.Quantity}\n" +
                $"Price per unit (Before discount): {product2.Price}\n" +
                $"Price per unit (after discount): {product2.CalculateDiscountedPrice()}\n");

            Console.WriteLine($"Total Order Price (after all discounts): {order1.CalculateOrderPrice()}");
        }
    }
}
