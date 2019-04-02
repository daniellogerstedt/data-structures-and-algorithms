using System;
using System.Text;
using StacksAndQueues.Classes;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue<T>
    {
        public Stack<T> Front { get; set; }
        public Stack<T> Back { get; set; }

        public PseudoQueue()
        {
            Front = new Stack<T>();
            Back = new Stack<T>();
        }

        /// <summary>
        /// Takes in a value and puts it in the back of the Queue as a new Node.
        /// </summary>
        /// <param name="val">The value to be placed in the new Node.</param>
        public void Enqueue(T val)
        {
            Back.Push(val);
        }

        /// <summary>
        /// Cycles the Queue forward (Back Stack to Front Stack if Front is Empty) and then removes and returns the front Node.
        /// </summary>
        /// <returns>The Node at the front of the Queue.</returns>
        public Node<T> Dequeue()
        {
            if (Front.Peek() == null) CycleQueue();
            return Front.Pop();
        }

        /// <summary>
        /// Cycles the Queue if nessisary then returns the Front Node without removing it.
        /// </summary>
        /// <returns>The Front Node in the Queue.</returns>
        public Node<T> Peek()
        {
            if (Front.Peek() == null) CycleQueue();
            return Front.Peek();
        }

        /// <summary>
        /// Helper method that moves the entire Back Stack into the Front Stack so that the node at the "Front" of the Queue is now at the Top of the Front Stack.
        /// </summary>
        private void CycleQueue()
        {
            while (Back.Peek() != null) Front.Push(Back.Pop());
        }
    }
}
