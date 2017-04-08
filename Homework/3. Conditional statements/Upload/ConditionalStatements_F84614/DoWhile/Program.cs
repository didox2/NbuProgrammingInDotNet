using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            int n = 4;
            do
            {
                result = result * n;
                n--;
            } while (n > 0);

            Console.WriteLine(result);
        }
    }
}
