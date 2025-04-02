using System.Xml.Linq;

namespace Assignment12_2
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode (int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // -- Remove elements from linked list --
            RemoveElementsProg();

            Console.ReadKey();
        }

        static void RemoveElementsProg()
        {
            Console.WriteLine("\n-- Remove elements from linked list --\n");
            ListNode head = InitializeLinkedList();
            PrintLinkedList(head);
            int value = GetValue();
            head = RemoveElements(head, value);
            Console.WriteLine($"\nAfter remove value of [{value}].");
            PrintLinkedList(head);
        }
        static ListNode RemoveElements(ListNode head, int val) // Leetcode #203 Time: O(N) Space: O(1)
        {
            if (head == null) return head;

            ListNode previous = null, current = head;

            while (current != null)
            {
                if (current.val == val) // Found value match
                {
                    if (current == head) // if it's 1st Node
                    {
                        head = current.next;
                    }
                    else
                    {
                        previous.next = current.next;
                    }
                }
                else  // Not match
                {
                    previous = current;
                }

                current = current.next;
            }

            return head;
        }
        static void PrintLinkedList(ListNode head)
        {
            ListNode current = head;
            

            Console.Write("\nList:\n[ ");
            if (head == null)
            {
                Console.WriteLine("]\n");
                return;
            }

            while (current != null)
            {
                Console.Write($"{current.val} -> ");
                current = current.next;
            }
            Console.WriteLine("\b\b\b] \n");
        }
        static ListNode InitializeLinkedList()
        {
            int count = 0, size;
            bool isValid;
            ListNode head = null, next;

            getSize:
            Console.Write("Enter the size of the list: ");
            isValid = int.TryParse(Console.ReadLine(), out size);

            if (!isValid)
            {
                Console.WriteLine("\nError! Enter a valid integer!");
                goto getSize;
            }
            
            while (count < size)
            {
                int val = 0;
            getNode:
                Console.Write($"Enter node {count + 1}: ");
                isValid = int.TryParse(Console.ReadLine(), out val);
                if (!isValid)
                {
                    Console.WriteLine("\nError! Enter a valid integer!");
                    goto getNode;
                }

                head = AddNodeToLast(head, val);
                count++;
            }

            return head;
        }
        static int GetValue()
        {
            int val;
            bool isValid;

        getValue:
            Console.Write("Enter value to remove: ");
            isValid = int.TryParse((Console.ReadLine()), out val);

            if (!isValid)
            {
                Console.WriteLine("\nError! Enter a valid integer!\n");
                goto getValue;
            }

            return val;
        }
        static ListNode AddNodeToLast(ListNode head, int val) // O(1) 
        {
            ListNode current = head;
            ListNode newNode = new ListNode(val);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while (current != null)
                {
                    if (current.next == null)
                    {
                        current.next = newNode; 
                        break;
                    }
                    current = current.next;
                }
            }

            return head;
        }
    }
}
