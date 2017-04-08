using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeIfGreater
{
/*
Problem 1.	Exchange If Greater
Write an if-statement that takes two integer variables a and b and exchanges their values if the first one 
is greater than the second one. As a result print the values a and b, separated by a space. 

Examples:
a	    b	    result
5	    2	    2 5
3	    4	    3 4
5.5	    4.5	    4.5 5.5
 */
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            
            Console.WriteLine("Before=> a:{0} - b:{1}", a, b);
            
            if (a > b)
            {
                int tempVariable = a;
                a = b;
                b = tempVariable;
            }

            Console.WriteLine("After=> a:{0} - b:{1}", a, b);
        }
    }
}
