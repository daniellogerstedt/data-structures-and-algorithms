using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BST<T> : BinaryTree<T> where T : IComparable<T>
    {

        /// <summary>
        /// Takes in data to place in a node before placing that node in the tree.
        /// </summary>
        /// <param name="data">The data for the node, must be a numeric comparable value.</param>
        public void AddNode(T data)
        {
            Node<T> node = new Node<T>();
            node.Data = data;
            if (Root == null)
            {
                Root = node;
                return;
            }
            AddNode(Root, node);
        }

        /// <summary>
        /// Takes in a root node and node to add.
        /// </summary>
        /// <param name="root">The current node to compare to the node being added.</param>
        /// <param name="node">The node to be added to the tree.</param>
        private void AddNode(Node<T> root, Node<T> node)
        {
            if (root.Data.CompareTo(node.Data) > 0)
            {
                if (root.Left == null) root.Left = node;
                else AddNode(root.Left, node);
            }
            else
            {
                if (root.Right == null) root.Right = node;
                else AddNode(root.Right, node);
            }
        }

        /// <summary>
        /// Searches the BST for the requested value and returns a boolean based on the result
        /// </summary>
        /// <param name="data">the value to be found</param>
        /// <returns>True if the value is in the tree, false if not.</returns>
        public bool Contains(T data)
        {
            Node<T> current = Root;
            while (current != null)
            {
                int comp = current.Data.CompareTo(data);
                if (comp == 0) return true;
                else if (comp == 1 && current.Left != null) current = current.Left;
                else if (comp == -1 && current.Right != null) current = current.Right;
                else current = null;
            }
            return false;
        }
    }
}
