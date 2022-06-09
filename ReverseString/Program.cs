using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the word to reverse :");
            string word = Console.ReadLine();

            char[] cArray = word.ToCharArray();
            string wordReverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                wordReverse += cArray[i];
            }
            Console.WriteLine("Your reverse word is: " + wordReverse);
        }
    }
}