using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 7: Sum of Even Digits
            //Write a program that reads an integer from the user and
            //prints the sum of its even digits.
            Console.WriteLine("Please enter  number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }

            Console.WriteLine("Sum of even digits " + sum);
        }
    }
}
