namespace Assignment5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- Check if an integer is a palindrome
            IsIntegerPalindromeProg();

            // -- Get sum of all digits in an integer --
            //GetSumofDigitsProg();

            // -- Check if array contains duplicate elements --
            //CheckDuplicateElementsProg();

            Console.ReadKey();
        }


        static void CheckDuplicateElementsProg()
        {
            Console.WriteLine("\n -- Check if array contains duplicate elements --\n");
            int[] arr = InitializeIntArray();
            Console.WriteLine($"Array contains duplicate elements: {ContainsDuplicateElements(arr)}");
        }
        static bool ContainsUniqueElements(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int i in arr)
            {
                if (set.Contains(i)) return false;
                else set.Add(i);
            }
            return true;
        }
        static bool ContainsDuplicateElements(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int i in arr)
            {
                if (set.Contains(i)) return true;
                else set.Add(i);
            }
            return false;
        }
        static void GetSumofDigitsProg()
        {
            int number, sum;
            bool isValid;

            Console.WriteLine("\n -- Get the sum of all digits in an integer --\n");
        getNumber:
            Console.Write("Enter a number: ");

            isValid = int.TryParse(Console.ReadLine(), out number);
            if (!isValid)
            {
                Console.WriteLine("\nError! Enter a valid integer!\n");
                goto getNumber;
            }
            sum = GetSumofDigits(number);
            Console.WriteLine($"The sum of the digits of the number {number} is : {sum}");
        }
        static int GetSumofDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        static void IsIntegerPalindromeProg()
        {
            int number;
            bool isValid;

            Console.WriteLine(" -- Check if an integer is a palindrome number --\n");
        getNumber:
            Console.Write("Enter a number: ");

            isValid = int.TryParse(Console.ReadLine(), out number);
            if (!isValid)
            {
                Console.WriteLine("\nError! Enter a valid integer!\n");
                goto getNumber;
            }
            IsIntPalindrome(number);
            Console.WriteLine($"Number: {number} is a palindrome - {IsIntPalindrome(number)}");
        }
        static bool IsIntPalindrome(int target)
        {
            int reverse = 0;
            int num = target;
            while (num > 0)
            {
                reverse = reverse * 10 + num % 10;
                Console.WriteLine($"{reverse} = {reverse} * 10 + {num} % 10");
                num /= 10;
            }
            return reverse == target;
        }
        static int[] InitializeIntArray()
        {
            bool isValid;
            int size;
            int[] array;

        getSize:
            Console.Write("Enter the size of the array: ");
            isValid = int.TryParse(Console.ReadLine(), out size);
            if (!isValid || size == 0)
            {
                Console.WriteLine("\nError! Enter a valid integer!\n");
                goto getSize;
            }
            array = new int[size];

            for (int i = 0; i < size; i++)
            {
            getNumber:
                Console.Write($"Element - {i + 1}: ");
                isValid = int.TryParse(Console.ReadLine(), out array[i]);
                if (!isValid)
                {
                    Console.WriteLine("\nError! Enter valid integer: ");
                    goto getNumber;
                }
            }
            return array;
        }
    }
}
