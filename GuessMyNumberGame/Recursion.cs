using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class Recursion
    {
        public int CountGuesses(int guess, int number, int count)
        {
            count += 1;
            if (number == guess)
            {
                Console.WriteLine("You chose correctly.");
                //Console.ReadLine();
                return count = 10;
            }
            else if (guess > number  && count < 10)
            {
                Console.WriteLine("Your guess was too high. Try again.");
                guess = int.Parse(Console.ReadLine());
                //Console.ReadLine();
                return count += CountGuesses(guess,number, count);
            }
            else if (guess < number && count < 10)
            {
                Console.WriteLine("Your guess was too low. Try again.");
                guess = int.Parse(Console.ReadLine());
                //Console.ReadLine();
                return count += CountGuesses(guess, number, count);
            }
            return number;

        }
    }
}
