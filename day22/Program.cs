using System;


namespace ArvoreBinariaDeBusca
{
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

    public class BinaryTree{
        public Node Root {get; set;}

        public BinaryTree(int value = 0, bool hasRoot = false)
        {
           if(hasRoot)
           {
            Root = new Node(value);
           }
           else {
            Root = null;
           }
        }
    }

    public class BinarySearchTree(BinaryTree)
    {
        
    }
}
