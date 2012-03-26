using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Entities;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            Product productA = new Product();
            Product productB = new Product();
            Product productC = new Product();

            Customer customer = new Customer();

            order.Customer = customer;
            Product[] arrayProducts = new Product[3];
            arrayProducts[0] = productA;
            arrayProducts[1] = productB;
            arrayProducts[2] = productC;

            order.Products = arrayProducts;

            Console.WriteLine("arrayProducts[0].Identifier= " + arrayProducts[0].Identifier);
            Console.WriteLine("order.Customer= " + order.Customer.Identifier);

            arrayProducts[0].Identifier = 123456;

            customer.Identifier = "1234";
            Console.WriteLine("order.Customer= " + order.Customer.Identifier);

            Console.ReadKey();


        }
    }
}
