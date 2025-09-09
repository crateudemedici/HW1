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

                if (input == "*")
                {
                    Console.WriteLine("\n//End execution");
                    break;
                }

                string reversed = ReverseString(input);

                bool isPalindrome = IsPalindrome(input, reversed);

                Console.WriteLine();
                Console.WriteLine("Original String         Reversed String            Palindrome?");
                Console.WriteLine($"  {input,-20}    {reversed.ToLower(),-20}    {(isPalindrome ? "Yes" : "No")}");
                Console.WriteLine();
            }
        }

        static string ReverseString(string str)
        {
            char[] charArray = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                charArray[i] = str[str.Length - 1 - i];
            }

            return new string(charArray);
        }

        static bool IsPalindrome(string original, string reversed)
        {
            
            string originalLower = original.ToLower();
            string reversedLower = reversed.ToLower();

        
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