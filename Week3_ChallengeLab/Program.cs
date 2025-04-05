using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_ChallengeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- Check if a string is a palindrome --
            CheckPalindromeProg();

            // -- Calculate the sum of digits in a string --
            SumDigitsInStringProg();

            // -- Check array contains sum of target --
            CheckSumInArrayProg();

            // -- Remove substring "AB" or "CD" --
            MinLengthRemoveSubstringProg();

            Console.ReadKey();
        }

        static void CheckPalindromeProg()
        {
            Console.WriteLine("\n -- Check if a string is palindrome --\n");
        getString:
            Console.WriteLine("Enter a string to check: ");
            string str = Console.ReadLine();
            if (str.Length == 0)
            {
                Console.WriteLine("\nError! Can't be an empty string!\n");
                goto getString;
            }
            if (IsPalindrome(str))
            {
                Console.WriteLine($"String \"{str}\" is a palindrome!");
            }
            else
            {
                Console.WriteLine($"String \"{str}\" is NOT a palindrome!");
            }
        }

        static void SumDigitsInStringProg()
        {
            Console.WriteLine("\n -- Calculate the sum of digits in a string --\n");
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();

            Console.WriteLine($"Sum of digits in string \"{str}\" is {GetSumOfDigitsInString(str)}");
        }

        static void CheckSumInArrayProg()
        {
            int[] result, arr;
            int size, target;
            bool isValid;

            Console.WriteLine("\n -- Check if an array have a target sum --\n");
        getsize:
            Console.Write("Enter the size of the array: ");
            isValid = int.TryParse(Console.ReadLine(), out size);
            if (!isValid)
            {
                Console.WriteLine("\nError! Invalid integer!");
                goto getsize;
            }
            else if (size == 0)
            {
                Console.WriteLine("\nError! Can't be an empty array!");
                goto getsize;
            }

            arr = new int[size];

            for (int i = 0; i < size; i++)
            {
        getNumber:
                Console.Write($"Enter number - {i} : ");
                isValid = int.TryParse(Console.ReadLine(), out arr[i]);
                if (!isValid)
                {
                    Console.WriteLine("\nError! Invalid Entry!\n");
                    goto getNumber;
                }
            }
        GetTarget:
            Console.Write("Enter a target sum: ");
            isValid = int.TryParse(Console.ReadLine(), out target);
            if (!isValid)
            {
                Console.WriteLine("\nError! Invalid integer!");
                goto GetTarget;
            }
            result = GetTargetSumInArray(arr, target);
            PrintArray(arr);

            if (result[0] != -1)
            {
                Console.WriteLine($"The target {target} is sum of item {result[0]} and {result[1]}.");
            }
            else
            {
                Console.WriteLine($"No result of target {target} has been found.");
            }
        }

        static void MinLengthRemoveSubstringProg()
        {
            Console.WriteLine("\n -- Remove substring \"AB\" or \"CD\" --\n");
        getString:
            Console.WriteLine("Enter a string: ");
            string s = Console.ReadLine();
            if (s.Length == 0)
            {
                Console.WriteLine("\nError! Can't be empty string!");
                goto getString;
            }
            Console.WriteLine($"After removal of \"{s}\", minimum length: {MinLengthAfterRemove(s)}");

        }

        static bool IsPalindrome(string str)
        {
            string s = str.ToLower().Trim();

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1]) return false;
            }
            return true;
        }

        static int GetSumOfDigitsInString(string str)
        {
            if (str.Length == 0) return 0;
            int sum = 0;

            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                    sum += int.Parse(c.ToString());
            }
            return sum;
        }

        static int[] GetTargetSumInArray(int[] arr, int target)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (pairs.ContainsKey(target - arr[i]))
                {
                    return new int[] { pairs[target - arr[i]], i };
                }
                pairs.Add(arr[i], i);
            }

            return new int[] {-1, -1};
        }

        static int MinLengthAfterRemove (string str)
        {
            while (str.Contains("AB") || str.Contains("CD"))
            {
                str = str.Replace("AB", "");
                str = str.Replace("CD", "");
            }
            Console.WriteLine(str);
            return str.Length;
        }

        static void PrintArray(int[] arr)
        {
            Console.Write("\nArray: [");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\b]");
        }
    }
}
