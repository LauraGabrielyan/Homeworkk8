using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 9: Count Words in a Sentence

            //Write a program that reads a sentence from the user and
            //counts the number of words in the sentence.
            Console.Write("Please enter a sentence: ");
            string str = Console.ReadLine();
            int wordSum = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    wordSum++;
                }
            }

            Console.WriteLine("The number of words in the sentence " + wordSum);

        }
    }
}
