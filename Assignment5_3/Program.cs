namespace Assignment5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Check to see if possible to plant N plants ---
            CheckToPlantProg();
            // --- Count ways to climb the stairs ---
            NStepsProg();

            Console.ReadKey();
        }
        static void CheckToPlantProg()
        {
            int[] array;
            int plant;
            char option = 'y';

            Console.WriteLine("\n--- Check to see if possible to plant N plants ---\n");
            while (option == 'y' || option == 'Y')
            {
                array = InitializeIntArray();
                plant = GetInt();
                PrintArray(array);
                Console.WriteLine($"Possibility to plant {plant} in the flower bed is - {CheckToPlant(array, plant)}");
                option = GetOption();
            }
        }
        static bool CheckToPlant(int[] arr, int plant) // Time complexity O(N)
        {
            if (arr.Length == 0) return false;
            int count = 1, possible = 0;    // count starts from 1 to give the possibility to plant from first place [0, 0, 1, ...]

            foreach (int i in arr)
            {
                if (i == 0)
                    count++;
                else
                {
                    possible += ((count + 1) / 2 - 1); // 0 -> 0, 00 -> 0, 000 -> 1,  0000 -> 1, 
                    count = 0;
                }
            }

            possible += ((count + 2) / 2 - 1);  // count + 2 to give the possibility to plant at the last position [..., 1, 0, 0]
            return possible >= plant;
        }
        static void NStepsProg()
        {
            Console.WriteLine("\n--- Count ways to climb the stairs ---\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"There are {NSteps(i)} ways to climb {i} stairs to the top.");
            }
        }
        static int NSteps (int stairs) // Recursion 
        {
            if (stairs <= 2) return stairs;
            else
                return NSteps(stairs - 1) + NSteps(stairs - 2);      // 0->0, 1->1, 2->2, 3->3, 4->5, 5->8
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
                if (!isValid || array[i] > 1)   // check if it is larger than 1 
                {
                    Console.WriteLine("\nError! Enter valid integer: (0 or 1)");
                    goto getNumber;
                }
            }
            return array;
        }
        static int GetInt()
        {
            bool isValid;
            int num;
        getNumber:
            Console.Write($"Enter a number: ");
            isValid = int.TryParse(Console.ReadLine(), out num);
            if (!isValid || num < 1)
            {
                Console.WriteLine("\nError! Enter valid integer!");
                goto getNumber;
            }
            return num;
        }
        static char GetOption()
        {
            bool isValid;
            char c;
            getChar:
            Console.Write("\nContinue? (Y/N) ");
            isValid = char.TryParse(Console.ReadLine().Trim(), out c);
            if(!isValid && (c != 'y' || c != 'Y' || c != 'n' || c != 'N'))
            {
                Console.WriteLine("\nError! Enter a valid option!");
                goto getChar;
            }
            return c;
        }
        static void PrintArray(int[] arr)
        {
            Console.Write("\n[");
            foreach (int i in arr)
                Console.Write(i + ", ");
            Console.WriteLine("\b\b]");
        }
    }
}
