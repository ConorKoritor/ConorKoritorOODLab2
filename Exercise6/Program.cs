using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Program
    {
        private static int DoubleIt(int number)
        {
            Console.WriteLine("About to Double the number " + number.ToString());
            return number * 2;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query = numbers
                .Select(n => DoubleIt(n));
            Console.WriteLine("Before the foreach Loop");
            foreach(var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
