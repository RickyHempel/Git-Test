using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rnumber = rnd.Next(0,100);
            int guess;
            int tries=1;
            bool loop_control = false;

            Console.WriteLine("I am thinking of a number between 0 and 100! Can you guess the number.\n");
          
            do {
                Console.Write("\nPlease enter your guess!\n");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == rnumber)
                {
                    Console.WriteLine("\nHey you got this right the number was!The number of tries you took was:\n"+ tries);
                    loop_control = true;
                }
                else if (guess > rnumber)
                {
                    Console.WriteLine("\nYour number is too high please try again.\n");

                }
                else if(guess < rnumber)
                {
                    Console.WriteLine("\nYour was too low please try again.\n");
                }
                tries++;
            } while (!loop_control);
            Console.WriteLine("\nPress any button to quit the program!\n");
            Console.ReadKey();
        }
    }
}
