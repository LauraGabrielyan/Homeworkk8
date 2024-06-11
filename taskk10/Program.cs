using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System;

namespace taskk10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 10: Number Guessing Game

            //Write a program where the computer randomly selects a number between 1 and 100.
            //The user has to guess the number.The program should provide feedback if the guess
            //is too high or too low until the user guesses the correct number.
            int random = new Random().Next(1, 100);


            Console.WriteLine("Guess the number");

            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == random)
                {
                    Console.WriteLine("You guessed the correct number");
                    break;
                }
                else if (number > random)
                {
                    Console.WriteLine("Your guess is too high");

                }
                else
                {
                    Console.WriteLine("Your guess is too low");
                }
            }
        }
    }
}
