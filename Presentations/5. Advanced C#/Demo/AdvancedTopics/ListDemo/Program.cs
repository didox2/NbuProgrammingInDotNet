using AdvancedTopics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 4, 7, 15 };
            numbers.Add(5);

            List<FirstClass> classes = new List<FirstClass>();

            classes.Add(new FirstClass(15));
            numbers.RemoveAt(2);
            Console.WriteLine(numbers.Contains(7));

            Console.WriteLine(numbers.Capacity); 
        }
    }
}
