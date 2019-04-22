using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class BisectTen
    {
         public void bisectMain()
        {
            int[] list = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int length = list.Max();

            int guess = list.Max() / 2;

            Console.WriteLine("Select a number between 1 and 10 for the computer to search for:");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            int high = 10;
            int low = 1;

            bisectChopTen(list, guess, number, count, length, high, low);
        }
        public int bisectChopTen(int []list, int guess, int number, int count, int length, int high, int low)
        {
            count += 1;
            if (list[guess] == number)
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
                    return count += bisectChopTen(list, guess, number, count, length, high, low);
                }
                else
                {
                guess = (high + guess) / 2;
                }
                return count +=bisectChopTen(list, guess, number, count, length, high, low);
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
                    return count += bisectChopTen(list, guess, number, count, length, high, low);
                }
                else
                {
                guess = guess / 2;
                }
                return count += bisectChopTen(list, guess, number, count, length, high, low);
            }
            return number;
        }
    }
}
