using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_2
{
    internal class MyStackNode<T>
    {
        public T? value;
        public MyStackNode<T> next;

        public MyStackNode(T val)
        {
            this.value = val;
            next = null;
        }
        public MyStackNode(T val, MyStackNode<T> node)
        {
            this.value = val;
            this.next = node;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
