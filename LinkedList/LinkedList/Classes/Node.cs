using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Node
    {

        public Node next { get; set; }
        public int value { get; set; }

        /// <summary>
        /// Constructor that requires only a value and sets the next to null.
        /// </summary>
        /// <param name="value">Value to be stored in the node.</param>
        public Node(int value)
        {
            this.next = null;
            this.value = value;
        }

        /// <summary>
        /// Constructor that requires both a value and next node.
        /// </summary>
        /// <param name="value">Value to be stored in the node.</param>
        /// <param name="next">Node to be set as the next node.</param>
        public Node(int value, Node next)
        {
            this.next = next;
            this.value = value;
        }
    }
}
