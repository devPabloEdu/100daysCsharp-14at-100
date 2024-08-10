using System;
using System.Collections.Generic;

namespace ArvoreBinaria
{
    public class Tree
    {
        public Node Root { get; set; }

        public class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value)
            {
                Value = value;
            }

            public bool IsLeaf()
            {
                return Left == null && Right == null;
            }
        }

        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Node newNode = new Node(value);
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(Root);

                while (queue.Count > 0)
                {
                    Node currentNode = queue.Dequeue();
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = newNode;
                        break;
                    }
                    else
                    {
                        queue.Enqueue(currentNode.Left);
                    }
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = newNode;
                        break;
                    }
                    else
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }
            }
        }

        public void PreOrder()
        {
            PreOrder(Root);
        }

        private void PreOrder(Node node)
        {
            if (node == null) return;
            Console.WriteLine(node.Value);
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder()
        {
            InOrder(Root);
        }

        private void InOrder(Node node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.WriteLine(node.Value);
            InOrder(node.Right);
        }

        public void PostOrder()
        {
            PostOrder(Root);
        }

        private void PostOrder(Node node)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.WriteLine(node.Value);
        }

        public static void Main(string[] args)
        {
            Tree arvore = new Tree();
            arvore.Insert(37);
            arvore.Insert(11);
            arvore.Insert(66);
            arvore.Insert(8);
            arvore.Insert(17);
            arvore.Insert(42);
            arvore.Insert(72);

            Console.WriteLine("PreOrder:");
            arvore.PreOrder();
            Console.WriteLine("---------------");

            Console.WriteLine("InOrder:");
            arvore.InOrder();
            Console.WriteLine("---------------");

            Console.WriteLine("PostOrder:");
            arvore.PostOrder();
            Console.WriteLine("---------------");
        }
    }
}
