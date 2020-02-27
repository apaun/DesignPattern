using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDS
{
    class Program
    {
        static void Main(string[] args)
        {

            var tree = new Tree();
            tree.Insert(10);
            tree.Insert(20);
            tree.Insert(5);
            tree.Insert(6);
            tree.Insert(4);
            tree.Insert(15);
            tree.InOrder(tree.Root);
            Console.WriteLine();
            Console.WriteLine("Height : " + tree.Height(tree.Root));
            Console.WriteLine(tree.Diameter(tree.Root));
            Console.WriteLine("LCA of 4 and 6 : "  + tree.LCA(tree.Root, 4, 6));
            Console.WriteLine("Level of 4 : " + tree.NodeLevel(tree.Root, 4));
        }

       
    }


    public class Tree
    {
        private int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public TreeNode Root;

        public Tree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            if(Root == null)
                Root = new TreeNode(data);
            else
            {
                TreeNode curr = Root;
                TreeNode temp = Root;
                while (curr != null)
                {
                    temp = curr;
                    if (curr.Data > data)
                    {
                        curr = curr.Left;
                    }
                    else
                    {
                        curr = curr.Right;
                    }
                }

                if(temp.Data > data)
                    temp.Left = new TreeNode(data);
                else if(temp.Data < data)
                    temp.Right = new TreeNode(data);

            }

        }

        public void InOrder(TreeNode node)
        {
            if(node == null)
                return;
            InOrder(node.Left);
            Console.Write(node.Data + " ");
            InOrder(node.Right);
        }

        public int Height(TreeNode node)
        {
            if (node == null)
                return 0;

            int lh = Height(node.Left);
            int rh = Height(node.Right);


            return 1 + Max(lh, rh);
        }

        public int Diameter(TreeNode node)
        {
            if (node == null)
                return 0;

            int lh = Height(node.Left);
            int rh = Height(node.Right);

            int ld = Diameter(node.Left);
            int rd = Diameter(node.Right);


            return Max(lh + rh + 1, Max(ld, rd));
        }

        public TreeNode LCA(TreeNode node, int n1, int n2)
        {
            if (node == null)
                return node;

            if (node.Data == n1 || node.Data == n2)
                return node;

            var lnode = LCA(node.Left, n1, n2);
            var rnode = LCA(node.Right, n1, n2);

            if (lnode != null && rnode != null)
                return node;

            if (lnode != null)
                return lnode;
            else
                return rnode;
        }

        public int NodeLevel(TreeNode node, int d)
        {
            return NodeLevelUtil(node, d, 1);
        }

        private int NodeLevelUtil(TreeNode node, int d, int level)
        {
            if (node == null)
                return 0;

            if (node.Data == d)
                return level;

            int downLevel = NodeLevelUtil(node.Left, d, level + 1);
            if (downLevel != 0)
                return downLevel;

            return NodeLevelUtil(node.Right, d, level + 1);
        }
    }


    public class TreeNode
    {
        public int Data;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int data)
        {
            this.Data = data;
            Left = null;
            Right = null;

        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
