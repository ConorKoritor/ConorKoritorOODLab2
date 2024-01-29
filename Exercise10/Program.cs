using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            var query = names
                .Where(n => n.StartsWith("M"));

            foreach (var name in query)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
