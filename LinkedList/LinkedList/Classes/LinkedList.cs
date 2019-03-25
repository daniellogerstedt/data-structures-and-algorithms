using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LinkedList
    {
        public Node Head { get; set; }

        /// <summary>
        /// Constructor for Linked List
        /// </summary>
        public LinkedList()
        {

            this.Head = null;

        }

        /// <summary>
        /// Inserts a node with a given value to the Head of the linked list.
        /// </summary>
        /// <param name="value">The value to be placed on the new node.</param>
        public void Insert(int value)
        {
            Node newHead = new Node(value, this.Head);
            this.Head = newHead;
        }


        /// <summary>
        /// This method returns a boolean after determining whether a linked list includes a given value.
        /// </summary>
        /// <param name="value">The value being looked for within the linked list.</param>
        /// <returns>A boolean, true if the value provided is present in the linked list, false if not.</returns>
        public bool Includes(int value)
        {
            if (this.Head == null) return false;
            Node curr = this.Head;
            while (curr != null)
            {
                if (curr.Value == value) return true;
                curr = curr.Next;
            }
            return false;
        }


        /// <summary>
        /// Method to get the length of the linked list.
        /// </summary>
        /// <returns>The length of the linked list as an integer.</returns>
        public int Length()
        {
            if (this.Head == null) return 0;
            Node curr = this.Head;
            int count = 0;
            while (curr != null)
            {
                count++;
                curr = curr.Next;
            }
            return count;
        }


        /// <summary>
        /// Method to get the list as an array of integers.
        /// </summary>
        /// <returns>Array representation of the list.</returns>
        public int[] Print()
        {
            int len = Length();
            int[] arr = new int[len];
            Node curr = this.Head;
            int index = 0;
            while (curr != null)
            {
                arr[index] = curr.Value;
                index++;
                curr = curr.Next;
            }
            return arr;
        }


    }
}
