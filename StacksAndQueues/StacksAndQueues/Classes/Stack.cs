using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack<T>
    {
        public Node<T> Top { get; set; }

        /// <summary>
        /// Takes in a value and puts it on the top of the stack as a new Node.
        /// </summary>
        /// <param name="val">The value to be placed in the Node being created.</param>
        public void Push (T val)
        {
            Node<T> node = new Node<T>();
            node.Data = val;
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Takes in a node to be placed at the top of the stack.
        /// </summary>
        /// <param name="node">The node being placed at the top.</param>
        public void Push (Node<T> node)
        {
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Removes and returns the top node of the stack, if null returns null.
        /// </summary>
        /// <returns>The top node.</returns>
        public Node<T> Pop()
        {
            if (Peek() == null) return null;
            Node<T> output = Top;
            Top = Top.Next;
            return output;
        }

        /// <summary>
        /// Returns the top node of the stack.
        /// </summary>
        /// <returns>The top node.</returns>
        public Node<T> Peek ()
        {
            return Top;
        }

    }
}

