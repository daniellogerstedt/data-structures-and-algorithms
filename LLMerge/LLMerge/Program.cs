using System;
using SLinkedList.Classes;

namespace LLMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Takes in two LinkedList instances and merges them in a zipper format
        /// </summary>
        /// <param name="listOne">The first LinkedList to be merged</param>
        /// <param name="listTwo">The second LinkedList to be merged</param>
        /// <returns>The head of the two lists merged into one list, this list is also accessible in the first LinkedList.</returns>
        public static Node MergeLists(LinkedList listOne, LinkedList listTwo)
        {
            Node curr = listOne.Head;
            while (curr != null)
            {
                if (listTwo.Head == null) return listOne.Head;
                Node temp = curr.Next;
                curr.Next = listTwo.Head;
                if (temp == null)
                {
                    listTwo.Head = temp;
                    return listOne.Head;
                }
                listTwo.Head = listTwo.Head.Next;
                curr.Next.Next = temp;
                curr = temp;
            }
            listOne.Head = listTwo.Head;
            listTwo.Head = null;
            return listOne.Head;
        }
    }
}
