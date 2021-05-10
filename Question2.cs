using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Question2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the minimum value");
            int min_value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum value");
            int max_value = Convert.ToInt32(Console.ReadLine());
            if (min_value > max_value)
            {
                Console.WriteLine("Invalid entry");
            }
            else
            {
                Console.WriteLine("The prime numbers between {0} and {1} are ", min_value, max_value);
                for (int i = min_value; i <= max_value; i++)
                {
                    int flag = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                        Console.WriteLine(i);
                }
            }
        }
    }
}
