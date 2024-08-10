using System;

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

    }



}