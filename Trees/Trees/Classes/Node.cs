using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; } // Lesser In BST
        public Node<T> Right { get; set; } // Greater In BST
    }
}
