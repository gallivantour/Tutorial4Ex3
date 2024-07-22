using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4Ex3
{
    class Customer
    {
        public int id { get; set; }
        public string name { get; set; }

        public Customer(int i, string n)
        {
            id = i;
            name = n;
        }

        public List<Product> shoplist = new List<Product>();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer(101, "First Customer");
            Customer cust2 = new Customer(102, "Second Customer");

            Console.WriteLine($"Id of 1st customer is {cust1.id}");
            Console.WriteLine($"Name of 2nd customer is {cust1.name}");

            // product list below

            Product p1 = new Product();
            Product p2 = new Product();

            p1.id = 23;
            p1.price = 9.5;

            p2.id = 33;
            p2.price = 5.5;

            // adding products to customer shopping list

            cust1.shoplist.Add( p1 );
            cust2.shoplist.Add(p2);


        }
    }


    class Product
    {
        public int id { get; set; }
        public double price { get; set; }
    }
}
