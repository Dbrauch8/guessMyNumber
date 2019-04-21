using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class Bisection1000
    {
        Random rnd = new Random();

        public int ChopThousand(int guessThousand)
        {
            int rndNumber = rnd.Next(1, 1000);
            int count = 0;
            Console.WriteLine(guessThousand);
            Console.ReadLine();

            int[] newArray = new int[1000];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = i + 1;
                Console.WriteLine(newArray[i]);
            }
            Console.ReadLine();

            recursiveThousand([]newArray, int guessThousand, int rndNumber);
            return count;
        }

           public int recursiveThousand(int []newArray, int gessThousand, int rndNumber)
            {
                if (guessThousand == rndNumber)
                {
                    Console.WriteLine("You chose the correct number!");
                }
                else if (guessThousand < newArray[rndNumber - 1])
                {
                    Console.WriteLine($"You guessed {guessThousand}. Too low, select a higher number.");
                }
                else if (guessThousand > newArray[rndNumber - 1])
                {
                    Console.WriteLine($"You guessed {guessThousand}. Too high, select a lower number.");
                }
                return guessThousand;
            }



        //public int bisectThousand(int guess, int number, int count, int length)
        //{
        //    ount += bisectThousand(guess, number, count, length);
        //    }
        //    return number;

    }
}
