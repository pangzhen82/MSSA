namespace Week10_ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- Merge two sorted array --
            MergeTwoSortedArrayProg();

            // -- Find difference between two strings --
            FindDifferenceStringProg();
            
            Console.ReadKey();
        }
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            if (n == 1 || edges.Length == 0) return true;

            Queue<int> queue = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            queue.Enqueue(source);

            while (queue.Count() != 0)
            {
                source = queue.Dequeue();
                if (visited.Contains(source))
                    continue;
                else
                    visited.Add(source);
                for (int i = 0; i < edges.Length; i++)
                {
                    if (edges[i][0] == source)
                    {
                        if (edges[i][1] == destination)
                            return true;
                        else
                            queue.Enqueue(edges[i][1]);
                    }
                    else if (edges[i][1] == source)
                    {
                        if (edges[i][0] == destination)
                            return true;
                        else
                            queue.Enqueue(edges[i][0]);
                    }
                }
            }
            return false;
        }
        static void MergeTwoSortedArrayProg()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };

            Merge(nums1, 3, nums2, 3);

            Console.WriteLine("\n -- Merge two sorted array -- \n");
            PrintArray(nums1);
        }
        static void FindDifferenceStringProg()
        {
            string s = "bdagfec";
            string t = "bclgfade";

            Console.WriteLine("\n-- Find difference between two strings --\n");
            Console.WriteLine($"String 1 \"{s}\" differs from string 2 \"{t}\" is letter \'{FindTheDifference(s, t)}\'");
        }
        static void Merge(int[] nums1, int m, int[] nums2, int n) // leetcode #88
        {
            int last = m + n - 1;
            m--;
            n--;

            for (int i = last; i >= 0; i--)
            {
                if (m < 0)                 // check if m passes the starting of array1
                    nums1[i] = nums2[n--];
                else if (n < 0)            // check if n passes the starting of array2
                    nums1[i] = nums1[m--];
                else                       // assign larger number to the last available point of array1
                    nums1[i] = nums1[m] < nums2[n] ? nums2[n--] : nums1[m--];
            }
        }
        static char FindTheDifference(string s, string t) // Leetcode #389 
        {
            if (s.Length == 0) return t[0];

            int[] count = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;   // adding letter appearance count from s
                count[t[i] - 'a']--;   // reducing letter apperance count from t
            }
            count[t[t.Length - 1] - 'a']--; // handle the extra item in t

            for (int i = 0; i < 26; i++)
            {
                if (count[i] != 0) return (char)(i + 'a'); // the only extra letter count is not 0
            }
            return ' ';
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
