using System.ComponentModel;
using System.Numerics;
using System;

namespace taskk11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 11: Rock, Paper, Scissors Game
            //Write a program where the user plays Rock, Paper, Scissors against the computer.
            //The computer randomly selects one of the options, and the user inputs their choice.
            //The program then determines the winner.
            int computerChoice = new Random().Next(1, 4);
            while (true)
            {
                Console.WriteLine("Enter your choice Rock(1), Paper(2), or Scissors(3) or type 0 to quit");

                int userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 0)
                {
                    Console.WriteLine("Exit");
                    break;
                }

                switch (userChoice)
                {
                    case 1:
                    case 2:
                    case 3:

                        Console.WriteLine("You chose " + userChoice);
                        Console.WriteLine("Computer chose " + computerChoice);


                        switch (userChoice)
                        {
                            case 1:
                                switch (computerChoice)
                                {
                                    case 1:
                                        Console.WriteLine("Draw!");
                                        break;
                                    case 2:
                                        Console.WriteLine("Computer wins!");
                                        break;
                                    case 3:
                                        Console.WriteLine("You win!");
                                        break;
                                }
                                break;
                            case 2:
                                switch (computerChoice)
                                {
                                    case 1:
                                        Console.WriteLine("You win!");
                                        break;
                                    case 2:
                                        Console.WriteLine("Draw!");
                                        break;
                                    case 3:
                                        Console.WriteLine("Computer wins!");
                                        break;
                                }
                                break;
                            case 3:
                                switch (computerChoice)
                                {
                                    case 1:
                                        Console.WriteLine("Computer wins!");
                                        break;
                                    case 2:
                                        Console.WriteLine("You win!");
                                        break;
                                    case 3:
                                        Console.WriteLine("Draw!");
                                        break;
                                }
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
                        break;



                }
            }
        }

    }
}
