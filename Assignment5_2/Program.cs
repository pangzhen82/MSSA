namespace Assignment5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Get the length of the last word in string ----
            GetLengthOfLastWordProg();

            // --- Print the first 1 to N and N to 1 Numbers ---
            PrintFirstNatrualNumberProg();

            //--- Check if a string is palindrome with recursion ----
            CheckPalindromeProg();

            Console.ReadKey();
        }

        static void CheckPalindromeProg()
        {
            Console.WriteLine("\n--- Check if a string is palindrome with recursion ----\n");
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine($"String - \"{str}\" is a palindrome: {IsPalindrome_Recursion(str.Trim().ToLower(), 0, str.Trim().Length - 1)}");
        }
        static void GetLengthOfLastWordProg()
        {
            Console.WriteLine("\n--- Get the length of the last word in string ----\n");
            Console.WriteLine("Enter a sentence: ");
            string str = Console.ReadLine();
            Console.WriteLine($"The length of the last word is {LengthOfLastWord(str)}");
        }
        static void PrintFirstNatrualNumberProg()
        {
            int num;
            bool isValid;
            Console.WriteLine("\n--- Print the first 1 to N and N to 1 Numbers ---\n");
        getNumber:
            Console.Write("Enter a number to print: ");
            isValid = int.TryParse(Console.ReadLine(), out num);
            if(!isValid || num < 1)
            {
                Console.WriteLine("\nError! Enter a valid integer!\n");
                goto getNumber;
            }
            Console.WriteLine("\n---Printing first 1 to N numbers ---\n");
            Print1ToN(num);
            Console.WriteLine("\n---Printing first N to 1 numbers ---\n");
            PrintNTo1(num);
        }
        static int LengthOfLastWord(string str)
        {
            if (str == string.Empty) return 0;
            return str.Trim().Split(" ")[str.Trim().Split(" ").Length - 1].Length;
        }
        static void Print1ToN(int n)
        {
            if (n > 0)
            {
                Print1ToN(n - 1);
                Console.WriteLine(n);
            }
        }
        static void PrintNTo1(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                PrintNTo1(n - 1);
            }
        }
        static bool IsPalindrome_Recursion(string str, int left, int right)
        {
            if (left >= right) 
                return true;
            else if(str[left] != str[right]) 
                return false;
            else 
                return IsPalindrome_Recursion(str, left + 1, right - 1);
        }
    }
}
