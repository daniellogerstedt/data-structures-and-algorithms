using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.Classes;

namespace Challenges
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
        
        /// <summary>
        /// Takes in the node to get the height of
        /// </summary>
        /// <param name="curr">the node</param>
        /// <returns>the height of that node</returns>
        public static int GetHeight(Node<bool> curr) // 4 points
        {
            if (curr == null) return -1;
            return Math.Max(GetHeight(curr.Left), GetHeight(curr.Right)) + 1;
        }

        /// <summary>
        /// Takes in the tree to get the tree levels of
        /// </summary>
        /// <param name="curr">the root of the tree</param>
        /// <returns>the levels of that tree</returns>
        public static int GetLevels(Node<bool> curr) // 1 point
        {
            if (curr == null) return 0;
            return Math.Max(GetLevels(curr.Left), GetLevels(curr.Right)) + 1;
        }

        /// <summary>
        /// Takes in a tree to check if it is balanced
        /// </summary>
        /// <param name="curr">the tree to check</param>
        /// <returns>whether it is balanced or not</returns>
        public static bool CheckBalanced(Node<bool> curr) // 3 points
        {
            if (curr == null) return true;
            int left = GetLevels(curr.Left);
            int right = GetLevels(curr.Right);
            if (Math.Abs(left - right) > 1) return false;
            bool checkLeft = CheckBalanced(curr.Left);
            bool checkRight = CheckBalanced(curr.Right);
            if (checkLeft && checkRight) return true;
            return false;
        }

        /// <summary>
        /// Takes in a set of nodes and the root of a tree root, determines whether node 1 is an ancestor of node 2 inside the given tree.
        /// </summary>
        /// <param name="n1">The Ancestor Node</param>
        /// <param name="n2">The Descendant Node</param>
        /// <param name="root">The Tree Root</param>
        /// <returns>Whether or not the nodes are in the tree and node 2 is a descendant of node 1</returns>
        public static bool IsAncestor(Node<bool> n1, Node<bool> n2, Node<bool> root) // 3 points
        {
            if (Contains(n1, root) && Contains(n2, n1)) return true;
            return false;
        }

        /// <summary>
        /// Takes in a node and a root, checks if that node is in the tree represented by the root.
        /// </summary>
        /// <param name="node">The node being looked for</param>
        /// <param name="root">The tree being searched</param>
        /// <returns>Whether or not the node is in the tree</returns>
        private static bool Contains(Node<bool> node, Node<bool> root) // Helper for IsAncestor
        {
            Node<bool> curr;
            Queue<Node<bool>> queue = new Queue<Node<bool>>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                curr = queue.Dequeue();
                if (curr == node) return true;
                if (curr.Left != null) queue.Enqueue(curr.Left);
                if (curr.Right != null) queue.Enqueue(curr.Right);
            }
            return false;
        }


    }
}
