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
    public TreeNode getTreeMin(TreeNode node)
    {
        TreeNode currNode = node;

        while(currNode.left != null)
        {
            currNode = currNode.left;
        }
        
        return currNode;
    }

    //return maximum value stored in the tree
    public TreeNode getTreeMax(TreeNode node)
    {
        TreeNode currNode = node;

        while(currNode.right != null)
        {
            currNode = currNode.right;
        }
        
        return currNode;
    }

    //delete value in tree
    public void deleteNode(BinarySearchTree tree, int deleteVal)
    {
        TreeNode currNode = tree.root;
        TreeNode prevNode = null;

        while(currNode.value != deleteVal && (currNode.left != null || currNode.right != null))
        {
            if(currNode.value < deleteVal)
            {
                prevNode = currNode;
                currNode = currNode.right;
            }
            else if(currNode.value > deleteVal)
            {
                prevNode = currNode;
                currNode = currNode.left;
            }
        }

        if(currNode.value != deleteVal)
        {
            Console.WriteLine("Value specified does not exist in the tree.");
        }
        else if(currNode.left == null && currNode.right == null)
        {
            if(currNode.value < prevNode.value)
            {
                prevNode.left = null;
                Console.WriteLine(currNode.value + " successfully deleted.");                
            }
            else
            {
                prevNode.right = null;
                Console.WriteLine(currNode.value + " successfully deleted.");      
            }
        }
        else if(currNode.left != null && currNode.right != null)
        {
            TreeNode succ = getSuccessor(currNode);

            Console.WriteLine(currNode.value + " successfully deleted."); 
            currNode.value = succ.value;

            deleteNode(tree, succ.value);
        }
        else
        {
            if(currNode.left != null)
            {
                Console.WriteLine(currNode.value + " successfully deleted.");    
                currNode.value = currNode.left.value;
                currNode.left = null;
            }
            else
            {
                Console.WriteLine(currNode.value + " successfully deleted.");    
                currNode.value = currNode.right.value;
                currNode.right = null;
            }
        }
    }

    //return next highest value in tree after given value, -1 if none
    public TreeNode getSuccessor(TreeNode node)
    {
        return getTreeMin(node.right);
    }

    //return next lowest value in tree after given value, -1 if none
    public TreeNode getPredecessor(TreeNode node)
    {
        return getTreeMax(node.left);
    }
    //Search BFS
    public bool searchInOrder(TreeNode node, int val)
    {
        if(node == null)
            return false;

        if(node.value == val)
            return true;

        bool leftSide = searchInOrder(node.left, val);

        if(leftSide)
            return true;

        bool rightSide = searchInOrder(node.right, val);

        return rightSide;
    }
    //Search DFS: inorder, postorder, preorder

}