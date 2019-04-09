using System;
using System.Collections.Generic;
using Trees.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static BinaryTree<object> FizzBuzz(BinaryTree<object> tree)
        {
            if (tree != null && tree.Root != null)
            {
                Queue<Node<object>> queue = new Queue<Node<object>>();
                queue.Enqueue(tree.Root);
                while (queue.TryDequeue(out Node<object> current))
                {
                    if (current.Left != null) queue.Enqueue(current.Left);
                    if (current.Right != null) queue.Enqueue(current.Right);
                    int result;
                    if (int.TryParse(current.Data.ToString(), out result)
                        && result % 5 == 0
                        && result % 3 == 0
                        && result != 0)
                        current.Data = "FizzBuzz";
                    else if (int.TryParse(current.Data.ToString(), out result)
                        && (int)current.Data % 5 == 0
                        && result != 0)
                        current.Data = "Buzz";
                    else if (int.TryParse(current.Data.ToString(), out result)
                        && (int)current.Data % 3 == 0
                        && result != 0)
                        current.Data = "Fizz";
                }
            }
            return tree;
        }
    }
}
