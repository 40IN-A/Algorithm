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
            //var root = TreeFunctions.Tree(8);
            //Print(root, 0, 0, Console.WindowWidth);
            //Console.ReadLine();


            AVLTree<int> Oak = new AVLTree<int>();
            //                                            10                              10                                             
            Oak.Add(10);  //                            /   \                           /   \
            Oak.Add(3);   //                           /     \                         /     \
            Oak.Add(2);   //                          3      12      ====>            3       15
            Oak.Add(4);   //                         / \     / \                     / \      / \
            Oak.Add(12);  //                        2   4  null 15                  2   4    12  25
            Oak.Add(15);  //                                      \              
            Oak.Add(11);  //                                       25
            Oak.Add(25);  //

            Oak.Remove(11);

            foreach (var item in Oak)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }

        //public static void Print(Node newNode, int y, int left, int right)
        //{

        //    if (newNode == null)
        //        return;
        //    var x = left + (right - left) / 2;
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(newNode.Data);
        //    Print(newNode?.Left, y + 1, left, x);
        //    Print(newNode?.Right, y + 1, x, right);
        //}
    }
    //public class Node 
    //{
    //    public Node(int data)
    //    {
    //        Data = data;
    //    }
    //    public int Data { get; set; }
    //    public Node Left { get; set; }
    //    public Node Right { get; set; }

        
    //}

    //public static class TreeFunctions
    //{
    //    public static Node Tree(int n)
    //    {
    //        Node newNode = null;
    //        if (n == 0)
    //            return null;
    //        else
    //        {
    //            var nl = n / 2;
    //            var nr = n - nl - 1;
    //            newNode = new Node(n);
    //            newNode.Data = new Random().Next(0, 100);
    //            newNode.Left = Tree(nl);
    //            newNode.Right = Tree(nr);
    //        }
            
    //        return newNode;
    //    }

       

    //}

   
}
