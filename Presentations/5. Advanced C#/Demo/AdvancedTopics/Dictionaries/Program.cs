using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> numbers = new Dictionary<string, int>();

            numbers.Add("one", 1);
            int value = 0;

            if (numbers.TryGetValue("two", out value))
            {
                Console.WriteLine(value);
            }

            if (numbers.ContainsKey("one"))
            {
                //Console.WriteLine(numbers["two"]);
            }
        }

    }
}
