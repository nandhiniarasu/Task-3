using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task3
{
    class Question3
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the numbers");
            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 0)
                    break;
                else
                    numbers.Add(i);
            }
            IEnumerable<int> duplicates = numbers.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);
            Console.WriteLine("The repeated elements are");
            foreach (var item in duplicates)
            {
                Console.WriteLine(item);
            }
        }
    }
}
