using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task3
{
    class Question4
    {
        public static void Main(string[] args)
        {
            List<int> inputs = new List<int>();
            Console.WriteLine("enter inputs:");
            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Try to enter Positive integer");
                }
                else if (n > 0)
                {
                    inputs.Add(n);
                   
                }
                else if (n == 0)
                {
                    break;
                }
            }
            var num = (from i in inputs
                       select i).OrderBy(i => i).ToList();
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

        }
    }
}
