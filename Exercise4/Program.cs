using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo[] files = new DirectoryInfo(@"C:\\Windows").GetFiles();

            var query = from item in files
                        where item.Length > 1000
                        orderby item.Length descending, item.Name
                        select new
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
         
                        };
            Console.WriteLine("File Name\tSize\t\tCreation Date");

            foreach(var item in query)
            {
                Console.WriteLine(
                    "{0} \t{1} bytes, \t{2}",
                    item.Name, item.Length, item.CreationTime.ToShortDateString()
                    );
            }

            Console.ReadLine();
        }
    }
}
