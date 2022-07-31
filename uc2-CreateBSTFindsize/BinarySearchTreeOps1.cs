using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc2_CreateBSTFindsize
{
    
        internal class BinarySearchTreeOps1<T> where T : IComparable<T>
        {
            public T NodeData { get; set; }
            public BinarySearchTreeOps1<T> leftTree { get; set; }
            public BinarySearchTreeOps1<T> rightTree { get; set; }

            int leftCount = 0, rightCount = 0;
            bool result = false;

            public BinarySearchTreeOps1(T NodeData)
            {
                this.NodeData = NodeData;
                this.leftTree = leftTree;
                this.rightTree = rightTree;

            }

            public void Insert(T item)
            {
                T currentnodevalue = this.NodeData;

                if ((currentnodevalue.CompareTo(item)) > 0)
                {
                    if (this.leftTree == null)
                    {
                        this.leftTree = new BinarySearchTreeOps1<T>(item);
                        Console.WriteLine("> {0} is inserted in BinarySearchTree...", item);
                    }
                    else
                    {
                        this.leftTree.Insert(item);
                    }

                }

                else
                {
                    if (this.rightTree == null)
                    {
                        this.rightTree = new BinarySearchTreeOps1<T>(item);
                        Console.WriteLine("> {0} is inserted in BinarySearchTree...", item);
                    }
                    else
                    {
                        this.rightTree.Insert(item);
                    }
                }
            }


            public void InsertMultiItems(params T[] inputarray)
            {
                foreach (T item in inputarray)
                {
                    Insert(item);
                }
            }

            public void Count(BinarySearchTreeOps1<T> binarySearchTree)
            {


                if (this.leftTree != null)
                {
                    binarySearchTree.leftCount++;
                    this.leftTree.Count(binarySearchTree);
                }

                if (this.rightTree != null)
                {
                    binarySearchTree.rightCount++;
                    this.rightTree.Count(binarySearchTree);
                }

            }

            public void GetSizeOfBSt(BinarySearchTreeOps1<T> binarySearchTree)
            {
                Count(binarySearchTree);
                Console.WriteLine("Size of BST is :- " + (1 + this.leftCount + this.rightCount));

            }

            public void Display()
            {
                if (this.leftTree != null)
                {
                    this.leftTree.Display();
                }

                Console.WriteLine(this.NodeData.ToString());

                if (this.rightTree != null)
                {
                    this.rightTree.Display();
                }


            }

        }
    }


