using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialNumbers = new int[] { 1, 8, 5, 9, 156 };
            int[,] numbers = new int[10,2];
            int rows = numbers.GetLength(0);
            int cols = numbers.GetLength(1);
            string[] texts = new string[10];

            //texts[3].Trim();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    numbers[row, col] = row + col;
                }
                
            }

            foreach (var item in initialNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
