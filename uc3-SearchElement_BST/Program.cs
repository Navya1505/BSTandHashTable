// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information

using uc3_SearchElement_BST;

Console.WriteLine("----- Binary_Search_Tree -----\n");

BinarySearchTreeOps2<int> binarySearchTree = new BinarySearchTreeOps2<int>(56); //Root=56  

binarySearchTree.InsertMultiItems(30, 70, 22, 40, 60, 95, 11, 65, 3, 16, 63, 67);

Console.WriteLine("\n>> Binary_Search_Tree :- ");
binarySearchTree.Display();

binarySearchTree.GetSizeOfBSt(binarySearchTree);

binarySearchTree.IfExists(95, binarySearchTree);

Console.ReadKey();