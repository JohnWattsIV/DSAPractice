using System;

namespace DSAPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //BinarySearchTree insert test
            Console.WriteLine("Insert nodes: ");
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
            Console.WriteLine();

            //BinarySearchTree sum test
            Console.WriteLine("Sum of values in tree: " + newTree.treeSum(newTree.root));
            Console.WriteLine();

            //BinarySearchTree inorder traversal test
            Console.WriteLine("InOrder traversal:");
            newTree.printInOrder(newTree.root);
            Console.WriteLine();

            //BinarySearchTree print tree height at any node test
            Console.WriteLine("Tree height: " + newTree.getNodeHeight(newTree.root));
            Console.WriteLine();

            //BinarySearchTree delete node test
            newTree.deleteNode(newTree, 7);
            newTree.printInOrder(newTree.root);

            newTree.deleteNode(newTree, 1);
            newTree.printInOrder(newTree.root);
        }
    }
}
