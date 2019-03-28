using System;
using System.Collections.Generic;
using System.Text;

namespace SLinkedList.Classes
{
    public class Node
    {

        public Node Next { get; set; }
        public int Value { get; set; }

        /// <summary>
        /// Constructor that requires only a value and sets the next to null.
        /// </summary>
        /// <param name="value">Value to be stored in the node.</param>
        public Node(int value)
        {
            this.Next = null;
            this.Value = value;
        }

        /// <summary>
        /// Constructor that requires both a value and next node.
        /// </summary>
        /// <param name="value">Value to be stored in the node.</param>
        /// <param name="next">Node to be set as the next node.</param>
        public Node(int value, Node next)
        {
            this.Next = next;
            this.Value = value;
        }
    }
}
