using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2: Count Occurrences of a Character  
            //Write a program that reads a string and a character from the user and
            //counts how many times the character appears in the string.
            Console.WriteLine("Please enter string");
            string str = Console.ReadLine();
            Console.WriteLine("Please enter character");
            char charinput = Convert.ToChar(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (charinput == str[i])
                {
                    count++;
                }
            }

            Console.WriteLine("The character appears in the string  " + count + " times");
        }
    }
}
