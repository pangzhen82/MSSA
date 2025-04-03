namespace Assignment12_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- Remove duplicate letters from string --
            RemoveDuplicatesProg();

            Console.ReadKey();
        }

        static void RemoveDuplicatesProg()
        {
            Console.WriteLine("-- Remove duplicate letters from string --\n");
            Console.Write("Enter a string: ");

            string str = Console.ReadLine();
            Console.WriteLine($"\nOriginal string entered: \"{str}\"");
            str = RemoveDuplicates(str);
            Console.WriteLine($"\nAfter duplicates removal: \"{str}\"");
        }
        static string RemoveDuplicates(string s)  // Time: O(N)  Space: O(N)
        {
            if (s.Length == 1) return s;

            char[] cArr = s.ToCharArray(); // use array to modify

            int change = 0;

            for (int i = 0; i < s.Length; i++)
            {
                cArr[change] = s[i]; // assign char to array

                if (change > 0 && cArr[change] == cArr[change - 1]) // compare if duplicate char
                    change--;
                else
                    change++;
            }

            return new string(cArr, 0, change); // return new partial string
        }
    }
}
