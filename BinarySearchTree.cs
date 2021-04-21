class BinarySearchTree
{   
    public class TreeNode
    {
        public TreeNode(int item, TreeNode par)
        {
            value = item;
            parent = par;
            left = right = null;
        }

        public TreeNode(int item, TreeNode par, TreeNode le, TreeNode ri)
        {
            value = item;
            parent = par;
            left = le;
            right = ri;
        }

        public int value {get; set;}
        public TreeNode parent {get; set;}
        public TreeNode left {get; set;}
        public TreeNode right {get; set;}
    }

    TreeNode root;

    BinarySearchTree()
    {
        root = null;
    }

    //TODO: METHODS
    //insert value into tree
    //get count of values stored
    //print values in tree from min to max
    //delete tree
    //return true if value exists in tree
    //return height in nodes (single node height is 1)
    //return minimum value stored in the tree
    //return maximum value stored in the tree
    //delete value in tree
    //return next heighest value in tree after given value, -1 if none
    //BFS
    //DFS: inorder, postorder, preorder

}