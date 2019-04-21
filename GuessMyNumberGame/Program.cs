using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("GUESS MY NUMBER GAME! \n\nWelcome to the Guess My Number Game!\nChoose the game you would like to play.");
            Console.WriteLine("Press 1 to choose a number (1-10) and watch how the computer narrows down your number.");
            Console.WriteLine("Press 2 to guess a number between 1 and 1000.");
            Console.WriteLine("Press 3 to directly tell the computer whether is is high or low (we trust your integrity).");
            Console.WriteLine("Press q to quit");

            int choice;
           switch (choice);
            {
                case 1:
                
                
                return true;
                break;


            }

            Console.WriteLine("Choose a number between 1 and 1000.");
            int guessThousand = int.Parse(Console.ReadLine());
            Bisection1000 bisectChopThousand = new Bisection1000();
            bisectChopThousand.ChopThousand(guessThousand);

            Random rnd = new Random();

            int guess = int.Parse(Console.ReadLine());

            int[] list = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int length = list.Max();
            
            //Console.WriteLine($"List max = {list.Max()}");
            int number = rnd.Next(1, length);
            int count = 0;
            int high = 10;
            int low = 1;
            
            
            
            //BisectTen guessTen = new BisectTen();          
            //guessTen.bisectChopTen(guess, number, count, length, high, low);


            //Recursion recursion = new Recursion();
            //recursion.CountGuesses(guess, number, count);
        }        
    }
}
