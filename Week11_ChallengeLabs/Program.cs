using System.Text;

namespace Week11_ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- Sort colors in place --
            SortColorsInplaceProg();

            // -- Find Maximum "balloon" in string --
            MaxNumberOfBalloonsProg();

            Console.ReadKey();
        }

        static void SortColorsInplaceProg()
        {
            Console.WriteLine("\n-- Sort colors in place --\n");
            int[] arr = InitializeIntArray();
            Console.WriteLine("\nColors entered:");
            PrintArray(arr);
            Console.WriteLine("Sorted colors:");
            SortColors(arr);
            PrintArray(arr);
        }
        static void MaxNumberOfBalloonsProg()
        {
            Console.WriteLine("\n-- Find Maximum \"balloon\" in string --\n");
            Console.WriteLine("Enter a string to check for ballons:");
            string str = Console.ReadLine();
            Console.WriteLine($"\nString entered: {str}");
            Console.WriteLine($"Maximum number of \"balloon\" is {MaxNumberOfBalloons(str)}");
        }
        static void SortColors(int[] nums) // Leetcode #75   Time: O(N)   Space: O(1)
        {
            int[] count = new int[3];

            foreach (var num in nums) // get all count of 0, 1, 2 from nums
            {
                count[num]++;
            }
            for (int i = 0; i < count[0]; i++) // replace all 0s
            {
                nums[i] = 0;
            }
            for (int i = count[0]; i < nums.Length - count[2]; i++) // replace all 1s
            {
                nums[i] = 1;
            }
            for (int i = nums.Length - count[2]; i < nums.Length; i++) // replace all 2s
            {
                nums[i] = 2;
            }
        }
        static int MaxNumberOfBalloons(string text) // Leetcode #1189  Time: O(N) Space: O(1)
        {
            if (text.Length < 7) return 0;

            string word = "balon";
            var map = new Dictionary<char, int>();

            foreach (var c in word) // initial map with "balon" 
            {
                map.Add(c, 0);
            }

            foreach (var c in text) // count occurence of "balon" from text
            {
                if (map.ContainsKey(c))
                    map[c]++;
            }

            map['o'] /= 2; // balloon needs two 'o' and 'l'
            map['l'] /= 2;

            int min = int.MaxValue;
            foreach (var pair in map)
            {
                if (min > pair.Value) min = pair.Value;
            }
            return min;
        } 
        static int[] InitializeIntArray()
        {
            int size, num;
            bool isValid;
            int[] arr;

        getSize:
            Console.Write("Enter the size for array: ");
            isValid = int.TryParse(Console.ReadLine(), out size);
            if (isValid && size > 0)
            {
                arr = new int[size];
            }
            else
            {
                Console.WriteLine("Error! Enter a valid integer!");
                goto getSize;
            }

            for (int i = 0; i < arr.Length; i++)
            {
            getNumber:
                Console.Write($"Enter number for element - [{i + 1}] (0, 1, 2): ");
                isValid = int.TryParse(Console.ReadLine(), out num);
                if (isValid && num >= 0 && num <= 2)
                {
                    arr[i] = num;
                }
                else
                {
                    Console.WriteLine("Error! Enter a valid color (0, 1, 2).");
                    goto getNumber;
                }
            }

            return arr;
        }
        static void PrintArray(int[] arr)
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("\b\b ]\n");
        }
    }
}
