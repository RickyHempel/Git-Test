/***
Name-Ricky Hempel
Date-9/5/2017
Purpose-number guessing game file.
****/
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
            //values for the game
            Random rnd = new Random();
            int guess;
            int tries=1;
            bool loop_control = false;
           
            //gets user inputs and generate them into a random number
            Console.WriteLine("I am thinking of a number please enter which two numbers this number should be between! Can you guess the number.\n");
            Console.WriteLine("\nPlease enter a starting number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter an ending number");
            int y = Convert.ToInt32(Console.ReadLine());
            int rnumber = rnd.Next(x,y);


            do {

                Console.Write("\nPlease enter your guess!\n");
                guess = Convert.ToInt32(Console.ReadLine());
                //if user guess the number lets them know and tells them how many tries it took
                if (guess == rnumber)
                {
                    Console.WriteLine("\nHey you got this right the number was!The number of tries you took was:\n"+ tries);
                    loop_control = true;
                }
                //if guess is greater than the number lets user know and tries again
                else if (guess > rnumber)
                {
                    Console.WriteLine("\nYour number is too high please try again.\n");

                }
                //if guess is less than the number lets user know and tries again
                else if (guess < rnumber)
                {
                    Console.WriteLine("\nYour was too low please try again.\n");
                }
                //increases number of tries of the user.
                tries++;
            } while (!loop_control);
            //Lets user exit the program.
            Console.WriteLine("\nPress any button to quit the program!\n");
            Console.ReadKey();
        }
    }
}
