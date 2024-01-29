using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
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

            /* var query1 = from number in numbers
                          orderby number descending;

             var query2 = from number in query1
                          where number < 8
                          select number;

             var query3 = from number in query2
                          select DoubleIt(number); */

            var query1 = numbers
                .OrderByDescending(n => n);

            var query2 = query1
                .Where(n => n < 8);

            var query3 = query2
                .Select(n => DoubleIt(n));

            Console.WriteLine("Before the foreach Loop");
            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
