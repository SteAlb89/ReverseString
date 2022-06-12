using System;

namespace ReverseString2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");

            string word = Console.ReadLine();

            string reverse = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }
            Console.WriteLine($"Your reverse string is : {reverse}");
        }
    }
}