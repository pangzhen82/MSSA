namespace Assignment12_1
{
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- Ransom Node: Check if string a could be constructed by char in string b --
            RansomNoteProg();

            // -- Is Linked List a palindrome -- 
            IsLinkedListPalindromeProg();

            Console.ReadKey();
        }

        static void RansomNoteProg()
        {
            Console.WriteLine("\n-- Ransom Node: Check if string a could be constructed by char in string b --\n");
            string ransomNote, magazine;

            Console.Write("Enter ransomNote: ");
            ransomNote = Console.ReadLine();
            Console.Write("\nEnter magazine: ");
            magazine = Console.ReadLine();

            Console.WriteLine($"\nRansomNote: [{ransomNote}] can be constructed by magazine:[{magazine}] is [{CanConstruct(ransomNote, magazine)}]");
        }
        static void IsLinkedListPalindromeProg()
        {
            Console.WriteLine("\n-- Is Linked List a palindrome -- \n");
            ListNode node7 = new ListNode(1, null);
            ListNode node6 = new ListNode(3, node7);
            ListNode node5 = new ListNode(5, node6);
            ListNode node4 = new ListNode(7, node5);
            ListNode node3 = new ListNode(5, node4);
            ListNode node2 = new ListNode(3, node3);
            ListNode node1 = new ListNode(1, node2);
            PrintLinkedList(node1);
            Console.WriteLine($"Is the list palindrome: {IsPalindrome(node1)}");
            Console.WriteLine("\nAfter checking:");
            PrintLinkedList(node1);
        }
        static bool CanConstruct(string ransomNote, string magazine) // LeetCode #383 Time: O(N) Space: O(1) 
        {
            if (ransomNote.Length > magazine.Length) return false;

            int[] letters = new int[26];

            foreach (var c in magazine)
            {
                letters[c - 'a']++;
            }

            foreach (var c in ransomNote)
            {
                if (letters[c - 'a'] == 0)
                    return false;
                else
                    letters[c - 'a']--;
            }

            return true;
        }
        static bool IsPalindrome(ListNode head) // Leetcode #234 Time: O(N) Space: O(1)
        {
            if (head.next == null) return true;
            if (head.next.next == null) return head.val == head.next.val;

            ListNode current = head, fast = head;
            ListNode previous = null, next = null;

            while (fast.next != null && fast.next.next != null) // Iterate half of list to find middle node
            {
                fast = fast.next.next;
                next = current.next;  // reverse until mid-point
                current.next = previous;
                previous = current;
                current = next;
            }

            if (fast.next == null) // odd count of nodes
            {
                fast = current.next;
                next = previous.next;
                previous.next = current;
                current = previous;
                previous = next;
            }
            else                  // even count of nodes
            {
                fast = current.next;
            }

            if (fast.val != current.val) // Check value
                return false;

            while (next != null)
            {
                next = previous.next;
                previous.next = current;   // reverse first half of list back
                current = previous;
                previous = next;
                fast = fast.next;

                if (fast.val != current.val) // Check value
                    return false;
            }

            return true;
        }
        static void PrintLinkedList(ListNode head)
        {
            ListNode current = head;
            Console.Write("List:\n[ ");
            while (current != null)
            {
                Console.Write($"{current.val} -> ");
                current = current.next;
            }
            Console.WriteLine("\b\b\b\b ] \n");
        }
    }
}
