using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LinkedList
    {
        public Node head { get; set; }

        /// <summary>
        /// Constructor for 
        /// </summary>
        public LinkedList()
        {

            this.head = null;

        }

        /// <summary>
        /// Inserts a node with a given value to the head of the linked list.
        /// </summary>
        /// <param name="value">The value to be placed on the new node.</param>
        public void Insert(int value)
        {
            Node newHead = new Node(value, this.head);
            this.head = newHead;
        }

    }
}
