using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_007
{
    class Node
    {
        public string info;
        public Node lefftchild;
        public Node rihtchild;

        

        public Node(string i, Node l, Node r)
        {
            info = i;
            lefftchild = l;
            rihtchild = r;
        }
    }
    
    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; 
        }
        public void Insert(string element)
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null)
            {
                Console.WriteLine("Duplicate words not allowerd");
                return;
            }
            else 
            {
                tmp = new Node(element, null, null);
                if (parent == null) 
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    if (string.Compare(element, parent.info) < 0)
                        parent.lefftchild = tmp;
                }
                else
                {
                    parent.rihtchild = tmp;
                }
            }
        }
        