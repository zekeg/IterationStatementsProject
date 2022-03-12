using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an empty list of int numbers
            var numbers = new List<int>();

            //create an empty single int intialized at 0
            int num = 0;

            //populate the list by incrementing the num variable while it is less than 100
            do
            {
                num++;
                numbers.Add(num);

            } while (num < 100);

            //increment another hundred integers while the list is less than 200
            do
            {
                num++;
                numbers.Add(num);
            } while (num < 200);

            Console.WriteLine("Increase:");

            //list the numbers in the list in increasing order
            foreach (int i in numbers) {
                Console.WriteLine(i);
            } 


            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            //list the numbers in the list in decreasing order
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
