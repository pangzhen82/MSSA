namespace Assignment11_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- Array rank transform --
            ArrayRankTransformProg();

            // -- Get the majority element from array --
            MajorityElementProg();

            Console.ReadKey();
        }

        static void ArrayRankTransformProg()
        {
            Console.WriteLine("\n-- Array rank transform --\n");

            int[] arr = InitializeIntArray();
            Console.WriteLine("Array:");
            PrintArray(arr);
            int[] rank = ArrayRankTransform(arr);
            Console.WriteLine("Rank:");
            PrintArray(rank);
        }
        static void MajorityElementProg()
        {
            Console.WriteLine("\n-- Get the majority element from array --\n");

            int [] arr = InitializeIntArray();
            Console.WriteLine("Array:");
            PrintArray(arr);
            Console.WriteLine($"Majority element of the array is: {MajorityElement(arr)}");
        }
        static int[] ArrayRankTransform(int[] arr) // Leetcode 1331
        {

            int diff = 0;
            int[] myArr = (int[])arr.Clone();
            int[] result = new int[arr.Length];
            var map = new Dictionary<int, int>();
            Array.Sort(myArr);

            for (int i = 0; i < result.Length; i++)
            {
                if (map.ContainsKey(myArr[i]))
                    diff++;
                else
                    map.Add(myArr[i], i + 1 - diff);
            }
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = map[arr[i]];
            }

            return result;
        }
        static int MajorityElement(int[] nums) // Leetcode 169
        {
            var map = new Dictionary<int, int>();
            int n = nums.Length;

            foreach (var num in nums)
            {
                if (map.ContainsKey(num))
                    map[num]++;
                else
                    map.Add(num, 1);
                if (map[num] > (n / 2))
                    return num;
            }
            return 0;
        }
        static int[] InitializeIntArray()
        {
            int size, num;
            bool isValid;
            int[] arr;

            Console.Write("Enter the size for array: ");
        getSize:
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
                Console.Write($"Enter number for element {i + 1}: ");
                isValid = int.TryParse(Console.ReadLine(), out num);
                if (isValid)
                {
                    arr[i] = num;
                }
                else
                {
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
