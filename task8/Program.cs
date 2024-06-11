using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 8: Generate Random Numbers
            //Write a program that generates 10 random numbers between 1 and 100 and prints them.
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(1, 100);
                Console.WriteLine(randomNumber);
            }

        }
    }
}
