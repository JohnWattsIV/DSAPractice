using System;

public class BinarySearchTree
{   
    public class TreeNode
    {
        public TreeNode(int item)
        {
            value = item;
            parent = left = right = null;
        }

        public int value {get; set;}
        public TreeNode parent {get; set;}
        public TreeNode left {get; set;}
        public TreeNode right {get; set;}
    }

    public TreeNode root;

    public BinarySearchTree()
    {
        root = null;
    }

    //insert value into tree (assuming valid input)
    public void insertNode(int value)
    {
        TreeNode newNode = new TreeNode(value);
        
        if (root == null)
        {
            root = newNode;
            Console.WriteLine("Successfully inserted " + newNode.value + " as root");
            return;
        }

        TreeNode currNode = root;

        while (true)
        {
            if (currNode.left == null && newNode.value < currNode.value)
            {
                currNode.left = newNode;
                newNode.parent = currNode;
                Console.WriteLine("Successfully inserted " + newNode.value + " as left child of " + currNode.value);
                return;
            }
            else if (currNode.right == null && newNode.value > currNode.value)
            {
                currNode.right = newNode;
                newNode.parent = currNode;
                Console.WriteLine("Successfully inserted " + newNode.value + " as right child of " + currNode.value);
                return;                
            }
            else if (currNode.left != null && newNode.value < currNode.value)
            {
                currNode = currNode.left;
            }
            else if (currNode.right != null && newNode.value > currNode.value)
            {
                currNode = currNode.right;
            }
        }
    }

    //get count of values stored
    public int treeSum(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        return node.value + treeSum(node.left) + treeSum(node.right);
    }
    //print values in tree from min to max
    public void printInOrder(TreeNode node)
    {
        if(node == null)
        {
            return;
        }

        printInOrder(node.left);
        Console.WriteLine(node.value);
        printInOrder(node.right);
    }

    //return height in nodes (single node height is 1)
    public int getNodeHeight(TreeNode node)
    {
        return treeHeightCalc(node, 0);
    }

    private int treeHeightCalc(TreeNode node, int height)
    {
        int hi = height;
        if (node != null)
            hi++;
        else if(node == null)
            return hi;

        return Math.Max(treeHeightCalc(node.left, hi), treeHeightCalc(node.right, hi));
    }
    //return minimum value stored in the tree
    //return maximum value stored in the tree
    //delete value in tree
    //return next heighest value in tree after given value, -1 if none
    //Search BFS
    //Search DFS: inorder, postorder, preorder

}