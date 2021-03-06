using System;
using Xunit;
using SLinkedList.Classes;

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
            LinkedList listToTest = new LinkedList();
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
            LinkedList listToTest = new LinkedList();
            listToTest.Insert(value);
            Assert.Equal(value, listToTest.Head.Value);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 2, 1)]
        [InlineData(200, 100, 300)]
        public void TestMultipleInsertions(int v1, int v2, int v3)
        {
            LinkedList listToTest = new LinkedList();
            listToTest.Insert(v1);
            listToTest.Insert(v2);
            listToTest.Insert(v3);

            Assert.Equal(v3, listToTest.Head.Value);
            Assert.Equal(v2, listToTest.Head.Next.Value);
            Assert.Equal(v1, listToTest.Head.Next.Next.Value);

        }

        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(4)]
        public void TestKthFromEnd(int k)
        {
            LinkedList listToTest = new LinkedList();
            listToTest.Insert(1);
            listToTest.Insert(2);
            listToTest.Insert(3);
            listToTest.Insert(4);

            int actual = listToTest.KthFromEnd(k).Value;
            int expected = k;
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestKthFromEndNonExistentNode()
        {
            LinkedList listToTest = new LinkedList();
            listToTest.Insert(1);
            listToTest.Insert(2);
            listToTest.Insert(3);
            listToTest.Insert(4);

            Assert.Null(listToTest.KthFromEnd(5));
        }

        [Theory]
        [InlineData(1, 2, 3, 2, true)]
        [InlineData(3, 2, 1, 5, false)]
        [InlineData(3, 2, 1, 3, true)]
        [InlineData(200, 100, 300, 300, true)]
        public void TestLinkedListIncludes(int v1, int v2, int v3, int search, bool expected)
        {
            LinkedList listToTest = new LinkedList();
            listToTest.Insert(v1);
            listToTest.Insert(v2);
            listToTest.Insert(v3);

            bool actual = listToTest.Includes(search);
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void TestLengthOfLinkedList()
        {
            LinkedList listToTest = new LinkedList();
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
            LinkedList listToTest = new LinkedList();
            listToTest.Insert(1);
            listToTest.Insert(2);
            listToTest.Insert(3);
            listToTest.Insert(4);

            int[] actual = listToTest.Print();
            int[] expected = new int[] { 4, 3, 2, 1 };

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void TestAppendLinkedList(int expected)
        {
            LinkedList listToTest = new LinkedList();
            listToTest.Insert(1);
            Assert.Null(listToTest.Head.Next);
            listToTest.Append(expected);
            Assert.Equal(expected, listToTest.Head.Next.Value);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(5, 4)]
        [InlineData(1, 8)]
        public void TestInsertBeforeWithNullHead(int value, int before)
        {
            LinkedList listToTest = new LinkedList();
            Assert.Null(listToTest.Head);
            listToTest.InsertBefore(value, before);
            Assert.Equal(value, listToTest.Head.Value);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(5, 4)]
        [InlineData(1, 8)]
        public void TestInsertBeforeWithOneNode(int value, int before)
        {
            LinkedList listToTest = new LinkedList();
            listToTest.Insert(before);
            listToTest.InsertBefore(value, before);
            Assert.Equal(value, listToTest.Head.Value);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(5, 4)]
        [InlineData(1, 8)]
        public void TestInsertBeforeWithMultipleNodes(int value, int before)
        {
            LinkedList listToTest = new LinkedList();
            listToTest.Insert(before);
            listToTest.Insert(5);
            listToTest.InsertBefore(value, before);
            Assert.Equal(value, listToTest.Head.Next.Value);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(5, 4)]
        [InlineData(1, 8)]
        public void TestInsertAfterWithNullHead(int value, int after)
        {
            LinkedList listToTest = new LinkedList();
            Assert.Null(listToTest.Head);
            listToTest.InsertAfter(value, after);
            Assert.Equal(value, listToTest.Head.Value);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(5, 4)]
        [InlineData(1, 8)]
        public void TestInsertAfterWithOneNode(int value, int after)
        {
            LinkedList listToTest = new LinkedList();
            listToTest.Insert(after);
            listToTest.InsertAfter(value, after);
            Assert.Equal(value, listToTest.Head.Next.Value);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(5, 4)]
        [InlineData(1, 8)]
        public void TestInsertAfterWithMultipleNodes(int value, int after)
        {
            LinkedList listToTest = new LinkedList();
            listToTest.Insert(5);
            listToTest.Insert(after);
            listToTest.InsertAfter(value, after);
            Assert.Equal(value, listToTest.Head.Next.Value);
        }
    }
}
