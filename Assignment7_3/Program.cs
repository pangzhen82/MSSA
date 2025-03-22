using Assignment7_3.Mod8BinarySearchTree;

namespace Assignment7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---- Testing Binary Search Tree ----\n");
            BinarySearchTree tree = new BinarySearchTree();
            tree.InsertNode(tree.Root, 100);
            tree.InsertNode(tree.Root, 20);
            tree.InsertNode(tree.Root, 10);
            tree.InsertNode(tree.Root, 30);
            tree.InsertNode(tree.Root, 200);
            tree.InsertNode(tree.Root, 150);
            tree.InsertNode(tree.Root, 300);

            Console.WriteLine(tree.Count + " nodes in the tree now:\n");
            Console.WriteLine($"Current tree root value: {tree.Root.val}");
            
            Console.Write("In-order traverse: ");
            tree.InOrderTraverse(tree.Root);
            Console.WriteLine();
            Console.Write("Pre-order traverse: ");
            tree.PreOrderTraverse(tree.Root);
            Console.WriteLine();
            Console.Write("Post-order traverse: ");
            tree.PostOrderTraverse(tree.Root);
            Console.WriteLine();

            int target = 20;
            Node targetNode;

            if ((targetNode = tree.GetValueNode(target)) != null) 
                Console.WriteLine($"\nFound {targetNode.val} in the tree!");
            else 
                Console.WriteLine($"\n{target} not found!");
            Console.Write("In-order traverse: ");
            tree.InOrderTraverse(targetNode);
            Console.WriteLine();
            Console.Write("Pre-order traverse: ");
            tree.PreOrderTraverse(targetNode);
            Console.WriteLine();
            Console.Write("Post-order traverse: ");
            tree.PostOrderTraverse(targetNode);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
