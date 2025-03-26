namespace Assignment4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- Calculate the electric bill --
            CalculateElectricBillProg();

            // -- Count frequency of each item in an array --
            CountArrayElementFrequencyProg();

            // -- Find unique elements in an array --
            GetUniqueNumberProg();

            Console.ReadKey();
        }
        static void CountArrayElementFrequencyProg()
        {
            Dictionary<int, int> countTable = new Dictionary<int, int>();

            Console.WriteLine("\n -- Count the frequecy of each element in array --\n");

            int[] array = InitializeIntArray();

            foreach (int num in array)
            {
                if (countTable.ContainsKey(num))
                    countTable[num]++;
                else
                    countTable.Add(num, 1);
            }

            foreach (var item in countTable)
            {
                Console.WriteLine($"{item.Key} occurs {item.Value} times.");
            }
        }
        static void CalculateElectricBillProg()
        {
            int id, unit;
            string name;
            double bill;
            bool isValid;
            char option = 'y';
            Console.WriteLine("\n -- Calculate electric bill --\n");

            while (option == 'y' || option == 'Y')
            {
            getName:
                Console.Write("Enter customer Name: ");
                name = Console.ReadLine();

            getUnit:
                Console.Write("Enter unit customer used: ");
                isValid = int.TryParse(Console.ReadLine(), out unit);
                if (!isValid)
                {
                    Console.WriteLine("\nError! Enter valid integer!\n");
                    goto getUnit;
                }

                Customer customer = new Customer(name, unit);
                customer.Display();

                Console.WriteLine("\nContinue? (y/n)");
                getOption:
                isValid = char.TryParse(Console.ReadLine(), out option);
                if (!isValid)
                {
                    Console.WriteLine("Error! Enter a valid option!\n");
                    goto getOption;
                }
            }
        }
        static void GetUniqueNumberProg()
        {
            Console.WriteLine("\n -- Find the unique elements in array --\n");
            int[] array = InitializeIntArray();
            List<int> result = GetUniqueNumbers(array);
            Console.WriteLine("\nThe unique element(s) found in the array are: ");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static int[] InitializeIntArray()
        {
            bool isValid;
            int size;
            int[] array;

        getSize:
            Console.Write("Enter the size of the array: ");
            isValid = int.TryParse(Console.ReadLine(), out size);
            if (!isValid && size == 0)
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
        static List<int> GetUniqueNumbers(int[] nums)
        {
            Dictionary<int, int> countTable = new Dictionary<int, int>();
            List<int> result = new List<int>();

            foreach (int num in nums)
            {
                if (countTable.ContainsKey(num))
                {
                    countTable[num]++;
                }
                else
                {
                    countTable.Add(num, 1);
                }
            }

            if (countTable.Count > 0)
            {
                foreach(var current in countTable)
                {
                    if (current.Value == 1)
                    {
                        result.Add(current.Key);
                    }
                }
                return result;
            }
            return null;
            
        }
    }
}
