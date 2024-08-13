using System;
using System.Collections.Generic;

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

    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(int value = 0, bool hasRoot = false)
        {
            if (hasRoot)
            {
                Root = new Node(value);
            }
            else
            {
                Root = null;
            }
        }

        // Percurso em ordem simétrica (inorder)
        public void InorderTraversal(Node node = null)
        {
            if (node == null)
            {
                node = Root;
            }
            if (node.Left != null)
            {
                InorderTraversal(node.Left);
            }
            Console.Write(node.Value + " ");
            if (node.Right != null)
            {
                InorderTraversal(node.Right);
            }
        }

        // Percurso em pré-ordem (preorder)
        public void PreorderTraversal(Node node = null)
        {
            if (node == null)
            {
                node = Root;
            }
            Console.Write(node.Value + " ");
            if (node.Left != null)
            {
                PreorderTraversal(node.Left);
            }
            if (node.Right != null)
            {
                PreorderTraversal(node.Right);
            }
        }

        // Percurso em pós-ordem (postorder)
        public void PostorderTraversal(Node node = null)
        {
            if (node == null)
            {
                node = Root;
            }
            if (node.Left != null)
            {
                PostorderTraversal(node.Left);
            }
            if (node.Right != null)
            {
                PostorderTraversal(node.Right);
            }
            Console.Write(node.Value + " ");
        }

        // Altura da árvore
        public int Height(Node node = null)
        {
            if (node == null)
            {
                node = Root;
            }
            if (node == null)
            {
                return 0;
            }
            int hLeft = Height(node.Left);
            int hRight = Height(node.Right);
            return Math.Max(hLeft, hRight) + 1;
        }

        // Percurso em nível (level order)
        public void LevelOrderTraversal()
        {
            if (Root == null)
            {
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                Console.Write(node.Value + " ");

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }
    }

    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree(int value = 0, bool hasRoot = false)
            : base(value, hasRoot)
        {
        }

        // Método para inserir um novo valor na árvore
        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                return new Node(value);
            }
            if (value < root.Value)
            {
                root.Left = InsertRec(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = InsertRec(root.Right, value);
            }
            return root;
        }

        // Método para buscar um valor na árvore
        public bool Search(int value)
        {
            return SearchRec(Root, value);
        }

        private bool SearchRec(Node root, int value)
        {
            if (root == null)
            {
                return false;
            }
            if (root.Value == value)
            {
                return true;
            }
            if (value < root.Value)
            {
                return SearchRec(root.Left, value);
            }
            else
            {
                return SearchRec(root.Right, value);
            }
        }
    }

    class Program
    {
    static void Main(string[] args){
        BinarySearchTree arvoreDeTeste = new BinarySearchTree();

        arvoreDeTeste.Insert(61);
        arvoreDeTeste.Insert(89);
        arvoreDeTeste.Insert(66);
        arvoreDeTeste.Insert(13);
        arvoreDeTeste.Insert(51);
        arvoreDeTeste.Insert(16);
        arvoreDeTeste.Insert(55);
        arvoreDeTeste.Insert(11);
        arvoreDeTeste.Insert(79);
        arvoreDeTeste.Insert(77);
        arvoreDeTeste.Insert(82);
        arvoreDeTeste.Insert(32);

        Console.Clear();
        Console.WriteLine("Procurando pelo numero 55");
        Console.WriteLine(arvoreDeTeste.Search(55));
        Console.WriteLine("-----------------------");
        
    }
    }
}
