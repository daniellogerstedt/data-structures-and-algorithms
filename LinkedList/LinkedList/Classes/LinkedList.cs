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

            Head = null;

        }

        /// <summary>
        /// Inserts a node with a given value to the Head of the linked list.
        /// </summary>
        /// <param name="value">The value to be placed on the new node.</param>
        public void Insert(int value)
        {
            Node newHead = new Node(value, Head);
            Head = newHead;
        }


        /// <summary>
        /// This method returns a boolean after determining whether a linked list includes a given value.
        /// </summary>
        /// <param name="value">The value being looked for within the linked list.</param>
        /// <returns>A boolean, true if the value provided is present in the linked list, false if not.</returns>
        public bool Includes(int value)
        {
            if (Head == null) return false;
            Node curr = Head;
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
            if (Head == null) return 0;
            Node curr = Head;
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
            Node curr = Head;
            int index = 0;
            while (curr != null)
            {
                arr[index] = curr.Value;
                index++;
                curr = curr.Next;
            }
            return arr;
        }
        
        
        /// <summary>
        /// This method takes in a given value and appends it to the end of the Linked List as a new Node containing that value.
        /// </summary>
        /// <param name="value">The value to place in the new Node.</param>
        public void Append(int value)
        {
            if (Head == null) Head = new Node(value);
            else
            {
                Node curr = Head;
                while (curr.Next != null)
                {
                    curr = curr.Next;
                }
                curr.Next = new Node(value);
            }
        }


        /// <summary>
        /// Inserts a Node containing the first given value before the first Node containing the second given value.
        /// </summary>
        /// <param name="value">The value being placed in the new node.</param>
        /// <param name="before">The value of the node the new node is placed before.</param>
        public void InsertBefore(int value, int before)
        {
            if (!Includes(before)) Append(value);
            else
            {
                if (Head.Value == before) Insert(value);
                else
                {
                    Node curr = Head.Next;
                    Node prev = Head;
                    while (curr.Value != before)
                    {
                        prev = curr;
                        curr = curr.Next;
                    }

                    prev.Next = new Node(value, curr);
                }
            }
        }


        /// <summary>
        /// Places a node containing the first given value after the first node containing the second given value.
        /// </summary>
        /// <param name="value">The value being placed in the new node.</param>
        /// <param name="after">The value of the node to place the new node after.</param>
        public void InsertAfter(int value, int after)
        {
            if (!Includes(after)) Append(value);
            else
            {
                Node curr = Head;
                while (curr.Value != after)
                {
                    curr = curr.Next;
                }
                curr.Next = new Node(value, curr.Next);
            }
        }


        public Node KthFromEnd(int k)
        {
            Node curr = Head;
            for (int i = 0; i < k; i++)
            {
                if (curr == null) return null;
                curr = curr.Next;
            }
            Node kthNode = Head;
            while (curr != null)
            {
                curr = curr.Next;
                kthNode = kthNode.Next;
            }
            return kthNode;
        }


    }
}
