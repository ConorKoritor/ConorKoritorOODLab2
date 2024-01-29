using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = GetCustomers();
            var query = Customers
                .Where(c => c.City == "Dublin" || c.City == "Galway")
                .OrderBy(c => c.Name)
                .Select(c => c.Name);

            foreach (var customer in query)
            {
                Console.WriteLine(customer);
            }

            Console.ReadLine();

        }
        private static List<Customer> GetCustomers()
        {
            Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Joe", City = "Galway" };
            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);
            return customers;
        }
    }

}

public class Customer
{
    public string Name;
    public string City;
}
