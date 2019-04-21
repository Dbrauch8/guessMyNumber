using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class BisectTen
    {

        public int bisectChopTen(int guess, int number, int count, int length, int high, int low)
        {
            count += 1;
            if (guess == number)
            {
                Console.WriteLine("You chose correctly.");
                Console.ReadLine();
                return count = 10;
            }
            else if (guess < number && count < 10)
            {
                Console.WriteLine($"You guessed {guess}. Too low, try a higher number.");
                Console.WriteLine($"Number ={number}");
                Console.ReadLine();
                low = guess;
                if (high < guess + 3)
                {
                    guess = guess + 1;
                }
                else
                {
                guess = (high + guess) / 2;
                }
                return count +=bisectChopTen(guess, number, count, length, high, low);
            }

            else if (guess > number && count < 10)
            {
                Console.WriteLine($"You guessed {guess}. Too high, try a smaller number");
                Console.WriteLine($"Number ={number}");
                Console.ReadLine();
                high = guess;
                if (low > guess - 3)
                {
                    guess = guess - 1;
                }
                else
                {
                guess = guess / 2;
                }
                return count += bisectChopTen(guess, number, count, length, high, low);
            }
            return number;
        }
    }
}
