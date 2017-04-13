using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 8, 45, 121, 31, 5, 84, 777, 95 };

            var smallNumbers = numbers
                .Where(n => n < 50);

            var anotherSmallNumbers = from n in numbers
                                      where n < 50
                                      select n;

            Console.WriteLine("From Lambda");

            foreach (var item in smallNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("From Query");

            foreach (var item in anotherSmallNumbers)
            {
                Console.WriteLine(item);
            }

            var avgSmallNumbers = numbers
                .Where(n => n < 50)
                .Average();

            Console.WriteLine(avgSmallNumbers);

            var projection = numbers
                .Where(n => n % 2 == 0)
                .Select(n => 
                {
                    if (n > 10)
                    {
                        return n;
                    }

                    return 0;
                });

            foreach (var item in projection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
