using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Question5
    {
        public static void Main(string[] args)
        {
            int count = 0;
            do
            {
                Console.WriteLine("Enter Username: ");
                string user = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (user == "Admin" && password == "1234")
                {
                    Console.WriteLine("Welcome");
                    break;
                }

                else
                {
                    Console.WriteLine("Inavalid username or password");
                    Console.WriteLine("Try Again");
                    count = count + 1;
                }
            } while (count < 3);
            if (count >= 3)
            {
                Console.WriteLine("Sorry you have already tried 3 times");
            }
        }
    }
}
