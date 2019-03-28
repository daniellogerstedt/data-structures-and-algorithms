using System;

namespace SLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instantiation of a Linked List");
            Console.WriteLine("Classes.LinkedList linkedlist = new Classes.LinkedList();");
            Classes.LinkedList linkedlist = new Classes.LinkedList();
            Console.WriteLine($"linkedlist.Head == null: {linkedlist.Head == null}");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Insert Method");
            Console.WriteLine("linkedlist.Insert(87);");
            linkedlist.Insert(87);
            Console.WriteLine($"linkedlist.Head.Value: {linkedlist.Head.Value}");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            Console.Clear();


            Console.WriteLine("Append Method");
            Console.WriteLine("linkedlist.Append(42);");
            linkedlist.Append(42);
            Console.WriteLine($"linkedlist.Head.Value: {linkedlist.Head.Value}");
            Console.WriteLine($"linkedlist.Head.Next.Value: {linkedlist.Head.Next.Value}");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("InsertBefore Method");
            Console.WriteLine("linkedlist.InsertBefore(33, 42);");
            linkedlist.InsertBefore(33, 42);
            Console.WriteLine($"linkedlist.Head.Next.Value: {linkedlist.Head.Next.Value}");
            Console.WriteLine($"linkedlist.Head.Next.Next.Value: {linkedlist.Head.Next.Next.Value}");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("InsertAfter Method");
            Console.WriteLine("linkedlist.InsertAfter(55, 87);");
            linkedlist.InsertAfter(55, 87);
            Console.WriteLine($"linkedlist.Head.Value: {linkedlist.Head.Value}");
            Console.WriteLine($"linkedlist.Head.Next.Value: {linkedlist.Head.Next.Value}");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Includes Method");
            Console.WriteLine("linkedlist should contain the following values in nodes: 87, 55, 33, 42");
            Console.WriteLine("bool testTrue = linkedlist.Includes(55)");
            bool testTrue = linkedlist.Includes(55);
            Console.WriteLine($"testTrue should be true, testTrue: {testTrue}");
            Console.WriteLine("bool testFalse = linkedlist.Includes(99)");
            bool testFalse = linkedlist.Includes(99);
            Console.WriteLine($"testFalse should be False, testFalse: {testFalse}");

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("KthFromEnd Method");
            Console.WriteLine("linkedlist should contain the following values in nodes: 87, 55, 33, 42");
            Console.WriteLine("int KthValue = linkedlist.KthFromEnd(2).Value;");
            int KthValue = linkedlist.KthFromEnd(2).Value;
            Console.WriteLine($"KthValue should be 33, KthValue: {KthValue}");

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            Console.Clear();


            Console.WriteLine("Length Method");
            Console.WriteLine("linkedlist should contain the following values in nodes: 87, 55, 33, 42");
            Console.WriteLine("int length = linkedlist.Length()");
            int length = linkedlist.Length();
            Console.WriteLine($"length: {length}");

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Print Method");
            Console.WriteLine("linkedlist should contain the following values in nodes: 87, 55, 33, 42");

            Console.WriteLine("int[] array = linkedlist.Print();");
            int[] array = linkedlist.Print();
            Console.WriteLine("Printed array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"index {i}: {array[i]}");
            }


        }

    }
}
