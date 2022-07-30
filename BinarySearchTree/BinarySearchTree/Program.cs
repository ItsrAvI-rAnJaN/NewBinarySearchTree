using System;

namespace BinarySearchTree
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t##########################################################");
            Console.WriteLine("\t\t\t\t\tWELCOME TO BINARY SEARCH TREE PROGRAM ");
            Console.WriteLine("\t\t\t\t##########################################################");
            int choice;
            while (true)
            {


                Console.WriteLine("\n0. Exit");
                Console.WriteLine("1.Create Binary Search Tree by adding 56 and then adding 30 & 70");
                Console.WriteLine("2.Create Binary Search Tree shown in figure.");
                Console.Write("\nEnter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BinarySearchTree<int> binary1 = new BinarySearchTree<int>(56);
                        binary1.Insert(30);
                        binary1.Insert(70);
                        Console.WriteLine("\nBinary Search Tree (inorder traversal/Ascending) is :-");
                        binary1.Display();
                        break;
                    case 2:
                        BinarySearchTree<int> objTree = new BinarySearchTree<int>(56);
                        objTree.Insert(30);
                        objTree.Insert(70);
                        objTree.Insert(22);
                        objTree.Insert(40);
                        objTree.Insert(60);
                        objTree.Insert(95);
                        objTree.Insert(11);
                        objTree.Insert(65);
                        objTree.Insert(3);
                        objTree.Insert(16);
                        objTree.Insert(63);
                        objTree.Insert(67);
                        Console.WriteLine("\nBinary Search Tree (inorder traversal/Ascending) is :-");
                        objTree.Display();
                        objTree.Size();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Please choose correct Question Number");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
