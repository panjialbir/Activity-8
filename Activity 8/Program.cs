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
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.lefftchild;
                else
                    currentNode = currentNode.rihtchild;
            }
        }
        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr == null)
            {
                inorder(ptr.lefftchild);
                Console.WriteLine(ptr.info + " ");
                inorder(ptr.rihtchild);
            }
        }
        public void preorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + " ");
                preorder(ptr.lefftchild);
                preorder(ptr.rihtchild);
            }
        }
        public void postorder(Node ptr) 
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                postorder(ptr.lefftchild);
                postorder(ptr.rihtchild);
                Console.WriteLine(ptr.info + " ");
            }
        }
        static void Main(string[] args)
        {
            BinaryTree x = new BinaryTree();
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Implement insert operation");
                Console.WriteLine("2. Perform inorder traversal");
                Console.WriteLine("3. Perform preorder traversal");
                Console.WriteLine("4. Perform ipostorder traversal");
                Console.WriteLine("5. Exit");
                Console.Write("\nEnter your choice (1-5) : ");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        {
                            Console.Write("Enter a word: ");
                            string word = Console.ReadLine();
                            x.Insert(word);
                        }
                        break;
                    case '2':
                        {
                            x.inorder(x.ROOT);
                        }
                        break;
                    case '3':
                        {
                            x.preorder(x.ROOT);
                        }
                        break;
                    case '4':
                        {
                            x.postorder(x.ROOT);
                        }
                        break;
                    case '5':
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
