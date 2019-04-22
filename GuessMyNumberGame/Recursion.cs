using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class Recursion
    {
        Random rnd = new Random();

        public void recursionMain()
        {
            int number = rnd.Next(1, 1000);
            int count = 0;
            Console.WriteLine("Select a number between 1 and 1000.");
            int guess = int.Parse(Console.ReadLine());

            countGuesses(guess, number, count);
        }
        public int countGuesses(int guess, int number, int count)
        {
            count += 1;
            if (number == guess)
            {
                Console.WriteLine($"You chose correctly in {count -1} tries.");
                //Console.ReadLine();
                return count = 10;
            }
            else if (guess > number  && count < 10)
            {
                Console.WriteLine("Your guess was too high. Try again.");
                guess = int.Parse(Console.ReadLine());
                //Console.ReadLine();
                return count += countGuesses(guess,number, count);
            }
            else if (guess < number && count < 10)
            {
                Console.WriteLine("Your guess was too low. Try again.");
                guess = int.Parse(Console.ReadLine());
                //Console.ReadLine();
                return count += countGuesses(guess, number, count);
            }
            return number;

        }
    }
}
