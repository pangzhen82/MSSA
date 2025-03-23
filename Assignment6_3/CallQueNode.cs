using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_3
{
    internal class CallQueNode<T>
    {
        public T data;
        public CallQueNode<T> next;

        public CallQueNode(T val, CallQueNode<T> node)
        {
            this.data = val;
            this.next = node;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }
    }
}
