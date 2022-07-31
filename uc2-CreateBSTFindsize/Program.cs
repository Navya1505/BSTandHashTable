// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using uc2_CreateBSTFindsize;

Console.WriteLine("----- Binary_Search_Tree -----\n");

BinarySearchTreeOps1<int> binarySearchTree = new BinarySearchTreeOps1<int>(56); //Root=56  

binarySearchTree.InsertMultiItems(30, 70, 22, 40,90);

Console.WriteLine("\n>> Binary_Search_Tree :- ");
binarySearchTree.Display();

binarySearchTree.GetSizeOfBSt(binarySearchTree);

Console.ReadKey();