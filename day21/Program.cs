using System;
using System.Collections.Generic;

namespace ArvoreBinaria
{
    static void Main(string[] args)
    {
    
    }



    public class Tree
    {
        public Node Root {get; set;};
        public class Node
    {
        public int Value{get; set;};
        public Node Left{get; set;};
        public Node Right{get; set;};

        public Node(int value)
        {
            Value = value;
        }

        public bool IsLeaf(){
            return left == null && right == null;
        }
    }
        public void Insert(int value)
        {
            if(Root == null)
            {
                Root = new Node(value);
            } else {
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
                    } else {
                        queue.Enqueue(currentNode.Left);
                    }
                    if (currentNode.Right == null) {
                        currentNode.Right = newNode;
                        break;
                    } else {
                        queue.Dequeue(currentNode.Right);
                    }
                }
            }
        }


    }



}