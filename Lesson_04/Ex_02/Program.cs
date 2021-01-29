//using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = TreeFunctions.Tree(10);
            //Console.WriteLine($"{root}");
        }
    }
    public class Node
    {
        public Node(int data)
        {
            Data = data;
        }
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        static void Print(Node node, int y, int left, int right)
        {
            if (node == null)
                return;
            var x = left + (right - left) / 2;
            Console.SetCursorPosition(x, y);
            Console.Write(node.Data);
            Print(node?.Left, y + 1, left, x);
            Print(node?.Right, y + 1, x, right);
        }
    }

    public static class TreeFunctions
    {
        public static Node Tree(int n)
        {
            Node newNode = null;
            if (n == 0)
                return null;
            else
            {
                var nl = n / 2;
                var nr = n - nl - 1;
                newNode = new Node();
                newNode.Data = new Random().Next();
                newNode.Left = Tree(nl);
                newNode.Right = Tree(nr);
            }
            return newNode;
        }
    }

   
}
