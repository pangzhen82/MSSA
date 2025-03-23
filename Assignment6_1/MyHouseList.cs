using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment6_1
{
    internal class MyHouseList
    {
        private HouseNode head;
        private HouseNode tail;
        private int count;

        public HouseNode First { get { return head; } }
        public HouseNode Last { get { return tail; } }
        public int Count { get { return count; } }

        public MyHouseList(HouseNode node)
        {
            head = node;
            this.count = 1;
            tail = head;
        }
        public MyHouseList()
        {
            head = null;
            tail = null;
            this.count = 0;
        }
        
        public void AddToIndex(string addr, string type, int index) // O(N) index of each node starts 1, 2, 3...
        {
            if (index < 1 || index > this.Count + 1)    // invalid index
            {
                Console.WriteLine("Error! Invalid index!");
            }
            else if (IsEmpty() || index == 1) AddFirst(addr, type); // adding to the start of list
            else if (index == this.Count + 1) AddLast(addr, type); // adding to the end of list
            else   // adding the position in the middle
            {
                HouseNode current = head;
                HouseNode newNode = new HouseNode(addr, type);
                int i = 1;
                while (i < index - 1)
                {
                    current = current.next;
                    i++;
                }
                newNode.next = current.next;
                current.next = newNode;
                this.count++;
            }
        }
        public HouseNode RemoveToIndex(int index)
        {
            if (index < 1 || index > this.Count)    // invalid index
            {
                Console.WriteLine("Error! Invalid index!");
                return null;
            }
            else if (IsEmpty() || index == 1) return RemoveFirst(); // remove 1st node of list
            else if (index == this.Count) return RemoveLast(); // remvoe last node of list
            else
            {
                HouseNode current = head;
                int i = 1;
                while (i < index - 1)
                {
                    current = current.next;
                    i++;
                }
                HouseNode del = current.next;
                current.next = current.next.next;
                this.count--;
                return del;
            }
        }
        public void AddFirst(string addr, string type) // O(1) 
        {
            HouseNode newNode = new HouseNode(addr, type, this.head);
            this.head = newNode;
            if (this.IsEmpty()) tail = newNode;
            this.count++;
        }
        public void AddLast(string addr, string type) // O(1) 
        {
            HouseNode newNode = new HouseNode(addr, type);
            if (this.IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = tail.next;
            }
            this.count++;
        }
        public HouseNode RemoveFirst() //O(1)
        {
            HouseNode del;
            if (!this.IsEmpty())
            {
                del = head;
                this.head = this.head.next;
                if (this.Count == 1) tail = null;
                this.count--;
                return del;
            }
            return null;
        }
        public HouseNode RemoveLast() // O(N)
        {
            if (!this.IsEmpty())
            {
                HouseNode current = this.head;
                HouseNode del = tail;
                if (this.Count == 1)
                {
                    return RemoveFirst();
                }
                else
                {
                    while (current.next != tail)
                    {
                        current = current.next;
                    }
                    tail = current;
                    tail.next = null;
                }
                this.count--;
                return del;
            }
            return null;
        }
        public bool IsEmpty()
        {
            return this.count == 0;
        }
        public bool Search(int id, out int index) // O(N)
        {
            HouseNode current = this.head;
            int i = 1;
            while (current != null)
            {
                if (current.HouseID == id)
                {
                    index = i;
                    return true;
                }
                current = current.next;
                i++;
            }
            index = -1;
            return false;
        }
        public void Display() // O(N)
        {
            if (IsEmpty()) Console.WriteLine("Empty list!");
            else
            {
                Console.WriteLine($"House count: {Count} house(s) in the list.");
                HouseNode current = this.head;
                while (current != null)
                {
                    Console.WriteLine($"{current} ");
                    current = current.next;
                }
            }
        }
    }
}
