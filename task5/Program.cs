using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 5: Print Even Numbers
            // Write a program that reads two integers(start and end) from the user
            // prints all even numbers in that range.
            Console.WriteLine("Please enter start number");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter end number");
            int end = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
