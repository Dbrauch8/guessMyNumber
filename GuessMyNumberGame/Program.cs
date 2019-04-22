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
            Recursion recursion = new Recursion();
            BisectTen guessTen = new BisectTen();
            Bisection1000 thousand = new Bisection1000();
            mainMethod();

            void mainMethod()
            {
                Console.WriteLine("GUESS MY NUMBER GAME! \n\nWelcome to the Guess My Number Game!\nChoose the game you would like to play.");
                Console.WriteLine("Press 1 to choose a number (1-10) and watch how the computer narrows down your number.");
                Console.WriteLine("Press 2 to guess a number between 1 and 1000.");
                Console.WriteLine("Press 3 to directly tell the computer whether is is high or low (we trust your integrity).");
                Console.WriteLine("Press q to quit");

                char num = Console.ReadKey().KeyChar;

                switch (num)
                {
                    case '1':
                        guessTen.bisectMain();
                        break;
                    case '2':
                        recursion.recursionMain();
                        break;
                    case '3':
                        thousand.hundredMain();

                        break;
                    case '4':

                        break;
                    //default:
                }
            }
        }
    }
}
