using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_3
{
    internal class CallQueue <T>
    {
        private CallQueNode<T> front;
        private CallQueNode<T> rear;
        private int size;
        public int Length { get { return size; } }

        public CallQueue ()
        {
            this.front = null;
            this.rear = null;
            this.size = 0;
        }
        public bool IsEmpty()
        {
            return this.size == 0;
        }
        public void Enqueue(T val)
        {
            CallQueNode<T> newNode = new CallQueNode<T>(val, null);
            if (this.IsEmpty())
            {
                front = newNode;
            }
            else
            {
                rear.next = newNode;
            }
            rear = newNode;
            this.size++;
        }
        public void Dequeue()
        {
            T val;
            if (!this.IsEmpty())
            {
                val = front.data;
                this.front = front.next;
                this.size--;
                if (IsEmpty()) this.rear = null;
                Console.WriteLine(val + " has been removed from the queue.");
                //return val;
            }
            else
            {
                Console.WriteLine("Queue is empty!");
                //return null;
            }
        }
        public void Display() // O(N)
        {
            if (IsEmpty()) Console.WriteLine("Empty queue!");
            else
            {
                Console.WriteLine("\n   ******** Caller hotline ******** \n---------------------------------------------------------------------------\n");
                CallQueNode<T> current = this.front;
                int count = 1;
                while (current != null)
                {
                    Console.WriteLine($"{count++} - { current.data} is waiting on the line...");
                    current = current.next;
                }
                Console.WriteLine("\n---------------------------------------------------------------------------\n");
            }
        }
    }
}
