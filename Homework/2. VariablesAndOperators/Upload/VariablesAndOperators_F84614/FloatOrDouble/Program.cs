﻿/*
Problem 2.	Float or Double?

Which of the following values can be assigned to a variable of type float and which to a variable of type
double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them
to ensure no precision is lost.
*/
using static System.Console;

namespace FloatOrDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = 34.567839023D;
            float second = 12.345F;
            double third = 8923.1234857D;
            float forth = 3456.091F;

            WriteLine(first);
            WriteLine(second);
            WriteLine(third);
            WriteLine(forth);
        }
    }
}
