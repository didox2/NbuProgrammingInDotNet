using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDemo
{
    class ForDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Input N: ");
            string numN = Console.ReadLine();

            Console.Write("Input M: ");
            string numM = Console.ReadLine();
            
            int n = 0;
            int m = 0;

            int result = 1;

            if (Int32.TryParse(numN, out n) && Int32.TryParse(numM, out m) && m > 0)
            {
                for (int i = 0; i < m; i++)
                {
                    result *= n;
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Wrong number!");
            }
        }
    }
}
