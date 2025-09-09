using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while (true)
            {
                Console.Write("Enter string: ");
                input = Console.ReadLine();

                // Check if user wants to exit
                if (input == "*")
                {
                    Console.WriteLine("\n//End execution");
                    break;
                }

                // Manually reverse the string
                string reversed = ReverseString(input);

                // Check if palindrome (case-insensitive comparison)
                bool isPalindrome = IsPalindrome(input, reversed);

                // Display results in formatted table
                Console.WriteLine();
                Console.WriteLine("Original String         Reversed String            Palindrome?");
                Console.WriteLine($"  {input,-20}    {reversed.ToLower(),-20}    {(isPalindrome ? "Yes" : "No")}");
                Console.WriteLine();
            }
        }

        // Method to manually reverse a string without using built-in methods
        static string ReverseString(string str)
        {
            char[] charArray = new char[str.Length];

            // Fill the array from the end to the beginning
            for (int i = 0; i < str.Length; i++)
            {
                charArray[i] = str[str.Length - 1 - i];
            }

            return new string(charArray);
        }

        // Method to check if a string is a palindrome
        static bool IsPalindrome(string original, string reversed)
        {
            // Convert both strings to lowercase for case-insensitive comparison
            string originalLower = original.ToLower();
            string reversedLower = reversed.ToLower();

            // Manual comparison without using built-in string comparison
            if (originalLower.Length != reversedLower.Length)
                return false;

            for (int i = 0; i < originalLower.Length; i++)
            {
                if (originalLower[i] != reversedLower[i])
                    return false;
            }

            return true;
        }
    }
}