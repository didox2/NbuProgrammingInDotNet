using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DoWhileDemo
{
    class DoWhileDemo
    {
        static void Main(string[] args)
        {
            BigInteger result = 1;
            string num = Console.ReadLine();
            int n = 0;

            if (Int32.TryParse(num, out n) && n >= 0)
            {
                do
                {
                    result = result * n;
                    n--;
                } while (n > 1);

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Wrong number!");
            }
        }
    }
}
