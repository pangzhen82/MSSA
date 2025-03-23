using System.Net.Http.Headers;
using System.Security.AccessControl;

namespace Assignment6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Test My Generic Stack LL ---
            TestMyStackProg();

            // --- Product of array item except self ---
            ProductOfArrayExceptSelfProg();

            Console.ReadKey();
        }

        static void TestMyStackProg()
        {
            MyStackLL<int> stack = new MyStackLL<int>();
            stack.Push(9);
            stack.Push(5);
            stack.Push(3);
            stack.Push(7);
            stack.Push(2);
            stack.Display();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Display();
 
        }
        static void ProductOfArrayExceptSelfProg()
        {
            Console.WriteLine("\n--- Product of array item except self ---\n");
            int[] array = InitializeIntArray();
            int[] answer = ProductOfArrayExceptSelf(array);
            Console.WriteLine("\nProduct of items except self: ");
            PrintArray(answer);
        }
        static int[] ProductOfArrayExceptSelf(int[] arr) // arr[ 1, 2, 3, 4 ] ==> answer[ 24, 12, 8, 6 ]
        {
            if (arr == null || arr.Length == 0) return null;
            else
            {
                int[] answer = new int[arr.Length];
                int left = 1, right = 1;
                for (int i = 0; i < arr.Length; i++) // answer[ 1, 1, 2, 6 ] left: 24
                {
                    answer[i] = left;
                    left *= arr[i];
                }

                for (int i = arr.Length - 1; i >= 0; i--) // answer[ 24, 12, 8, 6 ] right: 24
                {
                    answer[i] *= right;
                    right *= arr[i];
                }

                return answer;
            }
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
            Console.Write("\n[ ");
            foreach (int i in arr)
                Console.Write(i + ", ");
            Console.WriteLine("\b\b ]");
        }
    }
}
