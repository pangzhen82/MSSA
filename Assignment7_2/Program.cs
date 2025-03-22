namespace Assignment7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Shell sort array ---
            ShellSortProg();

            // --- Reverse the vowels letters in a string ---
            ReverseVowelsInStringProg();

            // --- Check if two strings are anagram ---
            IsAnagramProg();

            Console.ReadKey();
        }

        static public void IsAnagramProg()
        {
            Console.WriteLine("\n --- Check if two strings are anagram ---\n");

            Console.WriteLine("Enter a string: ");
            string str1 = Console.ReadLine().Trim();

            Console.WriteLine("Enter another string: ");
            string str2 = Console.ReadLine().Trim();

            if (IsAnagram(str1, str2))
                Console.WriteLine($"\n\"{str1}\" and \"{str2}\" are anagram.");
            else
                Console.WriteLine($"\n\"{str1}\" and \"{str2}\" are NOT anagram.");
        }
        static public bool IsAnagram(string s1, string s2) // Time complexity: O(n)
        {
            if (s1.Length != s2.Length) { return false; }

            int[] alphabetCount = new int[26];

            for (int i = 0; i < s1.Length; i++)
            {
                alphabetCount[s1[i] - 'a']++;
                alphabetCount[s2[i] - 'a']--;
            }

            foreach (int count in alphabetCount)
            {
                if (count != 0) return false;
            }

            return true;
        }
        static void ReverseVowelsInStringProg()
        {
            Console.WriteLine("\n --- Reverse the vowels letters in a string ---\n");

            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine().Trim();

            Console.Write("\nString:\t\t");
            PrintString(str);
            
            str = ReverseVowels(str);
            Console.Write("\nAfter reverse:\t");
            PrintString(str);
            Console.WriteLine(str);
        }
        static string ReverseVowels(string str)
        {
            if (str == null || str.Length == 0) return str;

            string vowels = "aeiouAEIOU";
            char[] charArray = str.ToCharArray();
            int i = 0, j = str.Length - 1;
            while (i < j)
            {
                if (vowels.Contains(charArray[i]) && vowels.Contains(charArray[j]))
                {
                    char temp = charArray[i];
                    charArray[i] = charArray[j];
                    charArray[j] = temp;
                    i++;
                    j--;
                }
                if (!vowels.Contains(str[i])) i++;
                if (!vowels.Contains(str[j])) j--;
            }
            return new string(charArray);
        }
        static void ShellSortProg()
        {
            Console.WriteLine("\n--- Shell sort an array ---\n");

            int[] arr = InitializeIntArray();

            Console.WriteLine("Array:");
            PrintArray(arr);

            Console.WriteLine("After shell sort:");
            ShellSort(arr);
            PrintArray(arr);
        }
       
        static void ShellSort(int[] arr)
        {
            if (arr == null || arr.Length == 0) return;

            int i, j, gap = arr.Length / 2;

            while (gap > 0)
            {
                //Console.WriteLine($"Gap : {gap}");
                for (i = gap; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    j = i - gap;
                    while (j >= 0 && arr[j] > temp)
                    {
                        arr[j + gap] = arr[j];
                        j -= gap;
                    }
                    arr[j + gap] = temp;
                    //PrintArray(arr);
                }
                gap /= 2;
            }
        } // O(N Log(N))
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
                if (!isValid)   // check if it is larger than 1 
                {
                    Console.WriteLine("\nError! Enter valid integer: ");
                    goto getNumber;
                }
            }
            return array;
        }
        static void PrintArray(int[] arr)
        {
            if (arr == null || arr.Length == 0) Console.WriteLine("\nEmpty Array!\n");
            Console.Write("[ ");
            foreach (int i in arr)
                Console.Write(i + ", ");
            Console.WriteLine("\b\b ]");
        }
        static void PrintString(string str)
        {
            if (str == null || str.Length == 0) Console.WriteLine("\nEmpty string!\n");

            Console.Write("\" ");
            foreach (char i in str)
                Console.Write(i + ", ");
            Console.WriteLine("\b\b \"");
        }
        
    }
}
