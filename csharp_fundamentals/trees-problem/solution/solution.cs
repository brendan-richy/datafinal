using System;

namespace solution
{
    public class TreeNode
    {
        // DONT CHANGE
        public int Data;
        public TreeNode? Left;
        public TreeNode? Right;

        public TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        // NO CHANGES til next commment
        public TreeNode? Root;

        public BinaryTree()
        {
            Root = null;
        }

        // Follow instructions
        public void PrintTree()
        {
            Console.WriteLine("Printing Tree Data:");
            PrintTree(Root);
            Console.WriteLine();
        }

        private void PrintTree(TreeNode? node)
        {
            if (node != null)
            {
                PrintTree(node.Left);
                Console.Write($"{node.Data} ");
                PrintTree(node.Right);
            }
        }

        public int Height()
        {
            return Height(Root);
        }

        private int Height(TreeNode? node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                int leftHeight = Height(node.Left);
                int rightHeight = Height(node.Right);

                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }

        public void AddNode(int data)
        {
            Root = AddNode(Root, data);
        }

        private TreeNode? AddNode(TreeNode? node, int data)
        {
            if (node == null)
            {
                return new TreeNode(data);
            }
            else
            {
                if (data < node.Data)
                {
                    node.Left = AddNode(node.Left, data);
                }
                else if (data > node.Data)
                {
                    node.Right = AddNode(node.Right, data);
                }

                return node;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Create a binary tree DONT CHANGE
            BinaryTree tree = new BinaryTree();
            tree.Root = new TreeNode(10);
            tree.Root.Left = new TreeNode(5);
            tree.Root.Right = new TreeNode(15);
            tree.Root.Left.Left = new TreeNode(2);
            tree.Root.Left.Right = new TreeNode(7);
            tree.Root.Right.Left = new TreeNode(12);
            tree.Root.Right.Right = new TreeNode(17);

            // TASK call methods to print initial tree data, the height of the tree
            // add nodes, reprint tree, and recheck height.
            tree.PrintTree();

            int initialHeight = tree.Height();
            Console.WriteLine($"Initial Height of the tree: {initialHeight}");

            tree.AddNode(8);

            tree.PrintTree();

            int updatedHeight = tree.Height();
            Console.WriteLine($"Updated Height of the tree: {updatedHeight}");
        }
    }
}
