namespace Assignment6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyHouseList houseList = new MyHouseList();
            houseList.AddFirst("Main street", "Condo");
            houseList.AddLast("Miller Ave.", "Single house");
            houseList.AddFirst("Sunset Blvd", "Mansion");
            houseList.AddLast("Colorado St.", "Ranch");
            houseList.AddFirst("101st Ave.", "Town house");
            houseList.AddLast("Pacific Cmn", "Single house");
            houseList.AddFirst("June circle", "Condo");
            houseList.AddLast("5th Avenue", "Apartment");
            houseList.AddLast("Hilltop Ave.", "Mansion");
            houseList.Display();

            houseList.RemoveFirst();
            houseList.RemoveLast();
            houseList.RemoveToIndex(5);
            Console.WriteLine("\nAfter removal: ");
            houseList.Display();

            // --- Move all 0s to the end of the array ---
            Move0ToLastProg();

            Console.ReadKey();
        }

        static void Move0ToLastProg()
        {
            Console.WriteLine("\n--- Move all 0s to the end of the array ---\n");
            int[] arr = InitializeIntArray();
            Move0ToLast(arr);
            PrintArray(arr);
        }
        static void Move0ToLast(int[] arr) // O(N) [ 0, 1, 0, 3, 12 ]
        {
            if (arr == null || arr.Length == 0) return;
            else
            {
                int change = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != 0)
                    {
                        SwapInt(ref arr[change++], ref arr[i]);
                    }
                }
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
            Console.Write("\n[");
            foreach (int i in arr)
                Console.Write(i + ", ");
            Console.WriteLine("\b\b]");
        }
        static void SwapInt(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
