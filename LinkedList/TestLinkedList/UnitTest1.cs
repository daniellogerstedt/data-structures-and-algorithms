using System;
using Xunit;
using LinkedList;

namespace TestLinkedList

    //Can successfully instantiate an empty linked list
    //Can properly insert into the linked list
    //The Head property will properly point to the first node in the linked list
    //Can properly insert multiple nodes into the linked list
    //Will return true when finding a value within the linked list that exists
    //Will return false when searching for a value in the linked list that does not exist
    //Can properly return a collection of all the values that exist in the linked list
{
    public class UnitTest1
    {
        [Fact]
        public void TestLinkedListInstantiation()
        {
            LinkedList.Classes.LinkedList listToTest = new LinkedList.Classes.LinkedList();
            Assert.Null(listToTest.Head);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(41)]
        [InlineData(31)]
        [InlineData(151)]
        public void TestAddNodeToLinkedList(int value)
        {
            LinkedList.Classes.LinkedList listToTest = new LinkedList.Classes.LinkedList();
            listToTest.Insert(value);
            Assert.Equal(value, listToTest.Head.Value);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 2, 1)]
        [InlineData(200, 100, 300)]
        public void TestMultipleInsertions(int v1, int v2, int v3)
        {
            LinkedList.Classes.LinkedList listToTest = new LinkedList.Classes.LinkedList();
            listToTest.Insert(v1);
            listToTest.Insert(v2);
            listToTest.Insert(v3);

            Assert.Equal(v3, listToTest.Head.Value);
            Assert.Equal(v2, listToTest.Head.Next.Value);
            Assert.Equal(v1, listToTest.Head.Next.Next.Value);

        }

        [Theory]
        [InlineData(1, 2, 3, 2, true)]
        [InlineData(3, 2, 1, 5, false)]
        [InlineData(3, 2, 1, 3, true)]
        [InlineData(200, 100, 300, 300, true)]
        public void TestLinkedListIncludes(int v1, int v2, int v3, int search, bool expected)
        {
            LinkedList.Classes.LinkedList listToTest = new LinkedList.Classes.LinkedList();
            listToTest.Insert(v1);
            listToTest.Insert(v2);
            listToTest.Insert(v3);

            bool actual = listToTest.Includes(search);
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void TestLengthOfLinkedList()
        {
            LinkedList.Classes.LinkedList listToTest = new LinkedList.Classes.LinkedList();
            listToTest.Insert(0);
            listToTest.Insert(0);
            listToTest.Insert(0);
            listToTest.Insert(0);
            listToTest.Insert(0);

            int actual = listToTest.Length();
            int expected = 5;

            Assert.Equal(expected, actual);

        }


        [Fact]
        public void TestPrintLinkedList()
        {
            LinkedList.Classes.LinkedList listToTest = new LinkedList.Classes.LinkedList();
            listToTest.Insert(1);
            listToTest.Insert(2);
            listToTest.Insert(3);
            listToTest.Insert(4);

            int[] actual = listToTest.Print();
            int[] expected = new int[] { 4, 3, 2, 1 };

            Assert.Equal(expected, actual);
        }

    }
}
