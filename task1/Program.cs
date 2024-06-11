using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Find the Largest Number
            //Write a program that reads 10 integers from the user and finds the largest number among them
            Console.WriteLine("Please enter 10 integer");
            int number;
            int maxnumber = 0;

            for (int i = 0; i < 10; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());

                if (number > maxnumber)
                {
                    maxnumber = number;
                }
            }
            Console.WriteLine("Max number is  " + maxnumber);

        }
    }
}
