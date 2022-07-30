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
                Console.WriteLine("1.Create Binary Search Tree byadding 56 and then adding 30 & 70");
                Console.Write("\nEnter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BinarySearchTree<int> binary1 = new BinarySearchTree<int>(56);
                        binary1.Insert(30);
                        binary1.Insert(70);
                        Console.WriteLine("\nBinary Search Tree (in inorder traversal) is :-");
                        binary1.Display();
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
