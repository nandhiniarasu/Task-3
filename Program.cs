//question 1

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < 10; i++)
            {
                int s = Convert.ToInt32(Console.ReadLine());
                numbers.Add(s);
            }
            Console.WriteLine("The numbers divisible by 7 are ");
            foreach (var i in numbers)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
