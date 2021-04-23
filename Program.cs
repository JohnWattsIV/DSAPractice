using System;

namespace DSAPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //BinarySearchTree Insert Test
            BinarySearchTree newTree = new BinarySearchTree();
            newTree.insertNode(8);
            newTree.insertNode(3);
            newTree.insertNode(1);
            newTree.insertNode(6);
            newTree.insertNode(4);
            newTree.insertNode(7);
            newTree.insertNode(10);
            newTree.insertNode(14);
            newTree.insertNode(13);
            newTree.insertNode(29);
        }
    }
}
