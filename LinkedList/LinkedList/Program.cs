using System;

namespace LinkedList
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

            bool haveInput = false;
            int inputNum = 0;
            while (!haveInput)
            {
                Console.WriteLine("Enter a integer to insert");
                string input = Console.ReadLine();
                haveInput = int.TryParse(input, out inputNum);
            }

            Console.WriteLine("Insert Method");
            Console.WriteLine("linkedlist.Insert(inputNum);");
            linkedlist.Insert(inputNum);
            Console.WriteLine($"linkedlist.Head.Value: {linkedlist.Head.Value}");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Adding other values to linkedlist: 55, 87, 33, 42");
            linkedlist.Insert(55);
            linkedlist.Insert(87);
            linkedlist.Insert(33);
            linkedlist.Insert(42);
            Console.WriteLine("Includes Method");
            Console.WriteLine($"linkedlist should contain the following values in nodes: {inputNum}, 55, 87, 33, 42");
            Console.WriteLine("bool testTrue = linkedlist.Includes(55)");
            bool testTrue = linkedlist.Includes(55);
            Console.WriteLine($"testTrue should be true, testTrue: {testTrue}");
            Console.WriteLine("bool testFalse = linkedlist.Includes(99)");
            bool testFalse = linkedlist.Includes(99);
            Console.WriteLine($"testFalse should be False, testFalse: {testTrue}");

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Length Method");
            Console.WriteLine($"linkedlist should contain the following values in nodes: {inputNum}, 55, 87, 33, 42");
            Console.WriteLine("int length = linkedlist.Length()");
            int length = linkedlist.Length();
            Console.WriteLine($"length: {length}");

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Print Method");
            Console.WriteLine($"linkedlist should contain the following values in nodes: {inputNum}, 55, 87, 33, 42");

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
