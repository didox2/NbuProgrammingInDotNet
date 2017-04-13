using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsDemo
{
    class WhileDemo
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int n = 0;
            int result = 0;

            if (Int32.TryParse(num, out n) && n >= 0)
            {
                while (n > 0)
                {
                    result = result + n;
                    n--;
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
