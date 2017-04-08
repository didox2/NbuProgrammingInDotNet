/*
 * Problem 5.	Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console.

HINT: Use Console.Write and Console.WriteLine to output data to the console
 */

using System;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Pesho";
            string lastName = "Petrov";
            sbyte age = 18;
            bool isMale = true;
            long personalIdNumber = 8306112507;
            long uniqueEmployeeNumber = 27569991;

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {(isMale ? "male" : "female")}");
            Console.WriteLine($"Personal ID number: {personalIdNumber}");
            Console.WriteLine($"Unique employee number: {uniqueEmployeeNumber}");
        }
    }
}
