using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue<T>
    {
        public Node<T> Front { get; set; }
        public Node<T> Back { get; set; }

        public Queue ()
        {
            Front = null;
            Back = null;
        }

        /// <summary>
        /// Takes in a value and puts it in the back of the Queue as a new Node.
        /// </summary>
        /// <param name="val">The value to be placed in the new Node.</param>
        public void Enqueue(T val)
        {
            Node<T> node = new Node<T>() { Data = val, Next = null };
            if (Back != null) Back.Next = node;
            Back = node;
            if (Front == null) Front = node;
        }

        /// <summary>
        /// Takes in a Node and puts it in the back of the Queue.
        /// </summary>
        /// <param name="val">The node being placed at the back.</param>
        public void Enqueue(Node<T> node)
        {
            node.Next = null;
            if (Back != null) Back.Next = node;
            Back = node;
            if (Front == null) Front = node;
        }

        /// <summary>
        /// Cycles the Queue forward (Back Stack to Front Stack if Front is Empty) and then removes and returns the front Node.
        /// </summary>
        /// <returns>The Node at the front of the Queue.</returns>
        public Node<T> Dequeue()
        {
            Node<T> output = Front;
            if (Front != null) Front = Front.Next;
            if (Front == null) Back = null;
            return output;
        }

        /// <summary>
        /// Cycles the Queue if nessisary then returns the Front Node without removing it.
        /// </summary>
        /// <returns>The Front Node in the Queue.</returns>
        public Node<T> Peek()
        {
            return Front;
        }

    }
}
