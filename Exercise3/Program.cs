using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo[] files = new DirectoryInfo(@"c:/windows").GetFiles();

            var query = from item in files
                        where item.Length > 1000
                        orderby item.Length descending, item.Name
                        select new MyFileInfo
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };
            Console.WriteLine(String.Format("{0,-40}{1,6:F0} MB {2}", "Filenames", "Size", "Creation Date"));

            foreach(MyFileInfo item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
