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
   