using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3: Average of Numbers
            //Write a program that reads 50 integers from the user and calculates their average.
            Console.WriteLine("Please enter 50 integer");
            int number;
            decimal sum = 0;
            for (int i = 0; i < 50; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;

            }
            decimal average = sum / 50;
            Console.WriteLine(" The average of these 50 numbers is equal to " + average);
        }
    }
}
