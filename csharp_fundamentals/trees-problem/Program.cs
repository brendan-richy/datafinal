using System;

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
    public TreeNode? Root;  // Nullable reference type

    public BinaryTree()
    {
        Root = null;
    }
    // Follow instructions
    public void PrintTree()
    {
        // TASK: Implement printing the data in every node by traversing the whole tree
    }

    public int Height()
    {
        // TASK: Implement finding the height of the tree
        return 0; // Placeholder, replace with the actual height
    }

    public void AddNode(int data)
    {
        // TASK: Implement manually adding another node to the tree
        // HINT: Check trees.md
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

        // TODO: Call methods to print initial tree data, find the initial height, 
        // manually add a node, print tree data after adding a node, and check the updated height
    }
}
