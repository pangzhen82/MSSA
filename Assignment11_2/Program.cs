using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace Assignment11_2
{
    public class ListNode
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
            // -- Best time to sell or buy stock --
            SellOrBuyStockProg();

            // -- Reverse Linked List --
            ReverseLinkedListProg();

            Console.ReadKey();
        }
        static void ReverseLinkedListProg()
        {
            Console.WriteLine("\n-- Reverse a linked list --\n");
            ListNode node5 = new ListNode(5, null);
            ListNode node4 = new ListNode(4, node5);
            ListNode node3 = new ListNode(3, node4);
            ListNode node2 = new ListNode(2, node3);
            ListNode node1 = new ListNode(1, node2);
            Console.WriteLine("Original list:");
            PrintLinkedList(node1);
            ListNode reversed = ReverseLinkedList(node1);
            Console.WriteLine("Reversed list:");
            PrintLinkedList(reversed);
        }
        static ListNode ReverseLinkedList(ListNode head) // Leetcode 206
        {
            ListNode current = head, previous = null, next = null;
            if (head == null) { return head; }

            while (current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            return previous;
        }
        static void SellOrBuyStockProg()
        {
            Console.WriteLine(" -- Best time to sell or buy stock --\n");
            int[] arr = InitializeIntArray();
            PrintArray(arr);
            Console.WriteLine($"\nMaximum profit for given array is: {SellOrBuyStock(arr)}\n");
        }
        static int SellOrBuyStock(int[] prices) // Leetcode 121
        {
            int buy = 0, sell = 1;
            int profit, maxProfit = 0;

            while (sell < prices.Length)
            {
                if (prices[buy] < prices[sell])
                {
                    profit = prices[sell] - prices[buy];
                    maxProfit = Math.Max(maxProfit, profit);
                }
                else
                {
                    buy = sell;
                }
                sell++;
            }
            return maxProfit;
        }
        static int[] InitializeIntArray()
        {
            int size, num;
            bool isValid;
            int[] arr;

            Console.Write("\nEnter the size for array: ");
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
            Console.WriteLine("\nArray:");
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("\b\b ]");
        }
        static void PrintLinkedList(ListNode head)
        {
            Console.Write("[ head -> ");
            while (head != null)
            {
                Console.Write(head.val + " ->  ");
                head = head.next;
            }
            Console.WriteLine("null ]\n");
        }
    }
}
