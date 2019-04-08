using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        /// <summary>
        /// Instantiates a list and calls the pre order traversal method using the Root and the list.
        /// </summary>
        /// <returns>The instantiated list after it has been filled with the data in the tree</returns>
        public List<T> PreOrder()
        {
            List<T> list = new List<T>();
            PreOrder(Root, list);
            return list;
        }

        /// <summary>
        /// PreOrder traversal method for filling a provided list with node data.
        /// </summary>
        /// <param name="root">The current node to look at.</param>
        /// <param name="list">The list to be filled for the outer method.</param>
        private void PreOrder(Node<T> root, List<T> list)
        {
            if (root == null || list == null) return;
            list.Add(root.Data);
            PreOrder(root.Left, list);
            PreOrder(root.Right, list);
        }

        /// <summary>
        /// Instantiates a list and calls the in order traversal method using the Root and the list.
        /// </summary>
        /// <returns>The instantiated list after it has been filled with the data in the tree</returns>
        public List<T> InOrder()
        {
            List<T> list = new List<T>();
            InOrder(Root, list);
            return list;
        }

        /// <summary>
        /// InOrder traversal method for filling a provided list with node data.
        /// </summary>
        /// <param name="root">The current node to look at.</param>
        /// <param name="list">The list to add node data into.</param>
        private void InOrder(Node<T> root, List<T> list)
        {
            if (root == null || list == null) return;
            InOrder(root.Left, list);
            list.Add(root.Data);
            InOrder(root.Right, list);
        }

        /// <summary>
        /// Instantiates a list and calls the post order traversal method using the Root and the list.
        /// </summary>
        /// <returns>The instantiated list after it has been filled with the data in the tree</returns>
        public List<T> PostOrder()
        {
            List<T> list = new List<T>();
            PostOrder(Root, list);
            return list;
        }

        /// <summary>
        /// PostOrder traversal method to add data to a provided list.
        /// </summary>
        /// <param name="root">The current node to look at.</param>
        /// <param name="list">The list to add node data into.</param>
        private void PostOrder(Node<T> root, List<T> list)
        {
            if (root == null || list == null) return;
            PostOrder(root.Left, list);
            PostOrder(root.Right, list);
            list.Add(root.Data);
        }
    }
}
