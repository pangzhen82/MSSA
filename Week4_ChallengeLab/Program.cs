using System.Security.Cryptography;

namespace Week4_ChallengeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- Check if a number contains a target number
            ContainsNumberProg();

            // -- Check two integers are divisible by 2 or 3 --
            DivisibleBy2Or3Prog();

            // -- Reverse a string in place --
            ReverseStringInPlaceProg();

            Console.ReadKey();
        }

        static void DivisibleBy2Or3Prog()
        {
            Console.WriteLine("\n-- Check two integers are divisible by 2 or 3 --\n");
            Console.WriteLine($"DivisibleBy2Or3({15}, {30}) -> {DivisibleBy2Or3(15, 30)}");
            Console.WriteLine($"DivisibleBy2Or3({2}, {90}) -> {DivisibleBy2Or3(2, 90)}");
            Console.WriteLine($"DivisibleBy2Or3({7}, {12}) -> {DivisibleBy2Or3(7, 12)}");
        }

        static void ContainsNumberProg ()
        {
            bool isValid;
            int number;
            int target;
            Console.WriteLine("\n -- Check if number contains digit 3 --\n");
        getNumber:
            Console.Write("Enter a number: ");
            isValid = int.TryParse(Console.ReadLine(), out number);

            if (!isValid)
            {
                Console.WriteLine("\nError! Enter integer only!");
                goto getNumber;
            }
        getTarget:
            Console.Write("Enter the target number: ");
            isValid = int.TryParse(Console.ReadLine(), out target);
            if(!isValid || target > 9)
            {
                Console.WriteLine("\nError! Enter one digit only!");
                goto getTarget;
            }

            if (ContainsNumber(number, target))
            {
                Console.WriteLine($"{number} contains number {target}");
            }
            else
            {
                Console.WriteLine($"{number} DOES NOT contains number {target}");
            }

        }

        static void ReverseStringInPlaceProg()
        {
            Console.WriteLine("\n-- Reverse a string in place --\n");
            getString:
            Console.Write("Enter a string to reverse: ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            if (str.Trim().Length > 0)
            {
                ReverseStringInPlace(arr);
            }
            else
            {
                Console.WriteLine("\nError! String can't be empty!");
                goto getString;
            }

            Console.WriteLine($"\nAfter reverse:");
            PrintCharArray(arr);
        }

        static void ReverseStringInPlace(char[] str)
        {
            char temp;
            for (int i = 0; i < str.Length / 2; i++)
            {
                temp = str[i];
                str[i] = str[str.Length - 1 - i];
                str[str.Length - 1 - i] = temp;
            }
        }

        static public void PrintCharArray(char[] arr)
        {
            foreach (char c in arr)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine();
        }

        static int DivisibleBy2Or3(int num1, int num2)
        {
            if ((num1 % 2 == 0 || num1 % 3 == 0) && (num2 % 2 == 0 || num2 % 3 == 0))
            {
                return num1 * num2;
            }
            else
            {
                return num1 + num2;
            }
        }

        //static bool StringContainsNumber (string str, char target)
        //{
        //    if (str != null && str.Length != 0)
        //    {
        //        foreach (char c in str)
        //        {
        //            if (c == target)
        //                return true;
        //        }
        //    }
        //    return false;
        //}
        static bool ContainsNumber(int number, int target)
        {
            int digit;
            while (number > 0)
            {
                digit = number % 10;
                if (digit == target)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        static bool IsDigitsOnly(string str)
         {
            if (str != null && str.Length > 0)
            {
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }
            else
                return false;
        }
    }
}
