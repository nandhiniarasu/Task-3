using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Question6
    {
        public static int min;

        public static void Main()
        {
            string[] arr = { "kite", "four", "neat", "play", "goal" };

            Console.WriteLine("start");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter your guess");
                string GuessWord = Console.ReadLine();
                string guessword = arr[i];
                int cow = 0, bulls = 0;
                if (guessword.Length == GuessWord.Length)
                {

                    for (i = 0; i < guessword.Length; i++)
                    {
                        if (guessword[i] == GuessWord[i])
                        {
                            cow += 1;
                        }
                        else
                        {
                            for (int j = 0; j < guessword.Length; j++)
                            {
                                if (guessword[i] == GuessWord[j] && i != j)
                                {
                                    bulls += 1;
                                }
                            }
                        }
                        Console.WriteLine("Cows:" + cow + " Bulls:" + bulls);
                    }

                    if (cow == guessword.Length)
                    {
                        Console.WriteLine(" You Won");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Must enter " + guessword.Length + " letter a Word");
                    
                }
            }
        }

