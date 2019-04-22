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

        public void hundredMain()
        {
            Console.WriteLine("Choose a number between 1 and 100 for the computer to find.");
            int number = int.Parse(Console.ReadLine());

            int[] newArray = new int[100];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = i + 1;
                Console.WriteLine(newArray[i]);
            }
            Console.ReadLine();
            int guess = newArray.Length / 2;
            int count = 0;
            int high = 100;
            int low = 1;


        recursiveHundred(newArray, guess, number, count, high, low);
        }

    public int recursiveHundred(int[] newArray, int guess, int number, int count, int high, int low)
    {
            count += 1;
            if (guess == number)
        {
            Console.WriteLine($"You chose the correct number! it took {count -1} tries");
        }
            else if (guess < number && count < 100)
            {
                Console.WriteLine($"You guessed {guess}. Too low, try a higher number.");
                Console.WriteLine($"Number ={number}");
                Console.ReadLine();
                low = guess;
                if (high < guess + 3)
                {
                    guess = guess + 1;
                    return count += recursiveHundred(newArray, guess, number, count, high, low);
                }
                else
                {
                    guess = (high + guess) / 2;
                }
                return count += recursiveHundred(newArray, guess, number, count, high, low);
            }
            else if (guess > number && count < 100)
            {
                Console.WriteLine($"You guessed {guess}. Too high, try a smaller number");
                Console.WriteLine($"Number ={number}");
                Console.ReadLine();
                high = guess;
                if (low > guess - 3)
                {
                    guess = guess - 1;
                    return count += recursiveHundred(newArray, guess, number, count, high, low);
                }
                else
                {
                    guess = guess / 2;
                }
                return count += recursiveHundred(newArray, guess, number, count, high, low);
            }
            return number;
        }
    }
}
