using System.Xml;

namespace Week5_ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Find the unique elements in an array ---
            FindUniqueElementsProg();

            // --- Find the missing number in array ---
            FindingMissingNumberProg();

            Console.ReadKey();
        }


        static void FindUniqueElementsProg()
        {
            Console.WriteLine("\n--- Find the unique elements in an array ---\n");
            int[] arr = { 1, 2, 3, 1, 5, 3, 5, 8, 2 };
            int unique = FindUniqueElements(arr);
            if (unique != -1)
            {
                Console.Write("Unique elements in array: {");
                foreach (int i in arr) 
                {
                    Console.Write($"{i}, ");
                }
                Console.WriteLine("\b\b} is " + unique);
            }
            else
            {
                Console.WriteLine("\nError! Invalid array!\n"); 
            }
        }
        static int FindUniqueElements(int[] arr) // Time complexity O(N)
        {
            HashSet<int> set = new HashSet<int>();

            if (arr == null || arr.Length == 0) return -1;

            foreach (int i in arr)
            {
                if (set.Contains(i))
                    set.Remove(i);
                else
                    set.Add(i);
            }
            return set.ToArray<int>()[0];
        }
        static void FindingMissingNumberProg()
        {
            Console.WriteLine("\n--- Find the missing number in array ---\n");

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 0 };
            int missing = FindMissingNumber(arr);
            if (missing != -1)
            {
                Console.Write("The number missing in array: {");
                foreach (int i in arr)
                {
                    Console.Write($"{i}, ");
                }
                Console.WriteLine("\b\b} is " + missing);
            }
            else
                Console.WriteLine("Can't find the missing number!");
        }
        static int FindMissingNumber(int[] arr)  // Time Complexity O(N)
        {
            HashSet<int> set = new HashSet<int>();

            if (arr == null || arr.Length == 0) return -1;

            foreach (int i in arr) // N
            {
                if (!set.Contains(i))
                    set.Add(i);
            }
            for (int i = 0; i <= arr.Length; i++) // N + 1
            {
                if (!set.Contains(i))
                    return i;
            }
            return -1;
        }
    }
}
