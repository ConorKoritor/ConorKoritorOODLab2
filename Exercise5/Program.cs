using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo[] files = new DirectoryInfo(@"C:\\Windows").GetFiles();

            var query = files
                .Where(f => f.Length > 1000)
                .OrderBy(f => f.Length)
                .Select(f => new
                {
                    Name = f.Name,
                    Length = f.Length,
                    CreationTime = f.CreationTime
                });
            Console.WriteLine("File Name\tSize\t\tCreation Date");

            foreach (var item in query)
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
