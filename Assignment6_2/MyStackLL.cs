using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_2
{
    internal class MyStackLL<T>
    {
        public MyStackNode<T> top;
        private int size;
        public int Size { get { return size; } }

        public MyStackLL()
        {
            this.top = null;
            this.size = 0;
        }

        //public T Peek()
        //{
        //    if (!IsEmpty())
        //    {
        //        T val = top.value;
        //        top = top.next;
        //        return val;
        //    }
        //    else
        //        return null;
        //}
        public bool IsEmpty()
        {
            return this.size == 0;
        }
        public void Push(T val)
        {
            MyStackNode<T> newNode = new MyStackNode<T>(val, top);
            this.top = newNode;
            this.size++;
        }
        public void Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Empty stack!");
            }
            else
            {
                T val = top.value;
                Console.WriteLine(val.ToString() + " removed!");
                top = top.next;
                size--;
            }
        }
        public void Display()
        {
            if (IsEmpty()) Console.WriteLine("Empty stack!");
            else
            {
                Console.WriteLine("\nStack:\n----------");
                MyStackNode<T> current = top;
                while (current != null)
                {
                    Console.WriteLine("|__ " + current.value.ToString() + " __|");
                    current = current.next;
                }
                Console.WriteLine("----------");
            }
        }
    }
}
