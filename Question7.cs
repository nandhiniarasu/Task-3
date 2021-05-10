using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Question7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Card Number");
            string Card_number = Console.ReadLine();
            if (Card_number.Length == 16)
            {
                Card_number = reverse(Card_number);
                Console.WriteLine(Card_number);
                string sum = Sumandmul(Card_number);
                Console.WriteLine(sum);
                string mod = ModAndCheck(sum);
                Console.WriteLine(mod);
            }
            else
                Console.WriteLine("Enter card length is 16");
        }
        private static string ModAndCheck(string sum)
        {
            int number = Convert.ToInt32(sum);
            if (number % 10 == 0)
                return "Valid Card";
            else
                return "Please verify correct number";
        }

        private static string reverse(string number)
        {
            string output = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                output += number[i];
            }
            return output;
        }
        private static string Sumandmul(string number)
        {
            int num_convert, mul, sum = 0, even_sum = 0, odd_sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                char v = number[i];
                num_convert = (int)Char.GetNumericValue(v);
                if ((i + 1) % 2 == 0)
                {
                    mul = num_convert * 2;
                    if (mul>= 10)
                    {
                        while (mul > 0)
                        {
                            int n = mul % 10;
                            even_sum += n;
                            mul = mul / 10;
                        }
                    }
                    else
                        even_sum += mul;
                }
                else
                {
                    odd_sum += num_convert;
                }
                sum = even_sum + odd_sum;
            }
            return Convert.ToString(sum);
        }

        static void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Enter the number to run the code");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Question1();
                        break;
                    case 2:
                        Question2();
                        break;
                    case 3:
                        Question3();
                        break;
                    case 4:
                        Question4();
                        break;
                    case 5:
                        Question5();
                        break;
                    
                    case 7:
                        Question7();
                        break;
                    case 8:
                        Console.WriteLine("Exitting");
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
            } while (choice != 8);
        }
        
    }
}
    