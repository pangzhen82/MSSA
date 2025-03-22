using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_3
{
    namespace Mod8BinarySearchTree
    {
        internal class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node(int val, Node left, Node right)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        internal class BinarySearchTree
        {
            public Node Root { get; private set; }
            public int Count { get; private set; }
            public BinarySearchTree()
            {
                this.Root = null;
                this.Count = 0;
            }

            public bool ContainsValue(int target)
            {
                Node current = this.Root;
                while (current != null)
                {
                    if (current.val == target) return true;
                    else if (target > current.val) current = current.right;
                    else current = current.left;
                }
                return false;
            }
            public Node GetValueNode(int target)
            {
                Node current = this.Root;
                while (current != null)
                {
                    if (current.val == target) return current;
                    else if (target > current.val) current = current.right;
                    else current = current.left;
                }
                return null;
            }
            public void InsertNode(Node root, int val)
            {
                Node newNode = new Node(val, null, null);
                Node previous = root, current = root;
                if (this.IsTreeEmpty())  // Very first node in tree
                {
                    this.Root = newNode;
                    return;
                }
                else
                {
                    while (current != null)
                    {
                        previous = current;
                        if (current.val < val) current = current.right;
                        else if (current.val > val) current = current.left;
                        else return;
                    }
                    if (previous.val > val)
                        previous.left = newNode;
                    else
                        previous.right = newNode;
                    this.Count++;
                }
            }
            public void InOrderTraverse(Node root)
            {
                if (root != null)
                {
                    InOrderTraverse(root.left);
                    Console.Write(root.val + " ");
                    InOrderTraverse(root.right);
                }
            }
            public void PreOrderTraverse(Node root)
            {
                if (root != null)
                {
                    Console.Write(root.val + " ");
                    PreOrderTraverse(root.left);
                    PreOrderTraverse(root.right);
                }
            }
            public void PostOrderTraverse(Node root)
            {
                if (root != null)
                {
                    PostOrderTraverse(root.left);
                    PostOrderTraverse(root.right);
                    Console.Write(root.val + " ");
                }
            }
            public bool IsTreeEmpty()
            {
                return this.Root == null;
            }
        }
    }
}
