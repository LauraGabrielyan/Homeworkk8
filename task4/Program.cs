using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 4: Check Palindrome
            //Write a program that reads a string from the user and checks if it is a palindrome.
            Console.WriteLine("Please enter string ");
            string str = Console.ReadLine();
            string str2 = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str2 += str[i];
            }
            if (str2 == str)
            {
                Console.WriteLine("String is palidrome");
            }
            else
            {
                Console.WriteLine("String is not palidrome");
            }
        }
    }
}
