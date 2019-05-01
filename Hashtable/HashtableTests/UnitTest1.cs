using Hashtable.Classes;
using static Hashtable.Program;
using Trees.Classes;
using System;
using Xunit;
using System.Collections.Generic;

namespace HashtableTests
{
    public class UnitTest1
    {
        [Fact]
        public void testRepeatedWord()
        {
            string test = "test/string]test,string,this&is(a)test";
            string expected = "test";
            string actual = RepeatedWord(test);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testRepeatedWordNull()
        {
            string test = "test/string]null}value";
            string actual = RepeatedWord(test);
            Assert.Null(actual);
        }

        [Fact]
        public void testRepeatedWordNoString()
        {
            string actual = RepeatedWord(null);
            Assert.Null(actual);
        }

        [Fact]
        public void testTreeIntersectionNoTreeOne()
        {
            List<int> actual = TreeIntersection(new BinaryTree<int>(), null);
            Assert.Null(actual);
        }

        [Fact]
        public void testTreeIntersectionNoTreeTwo()
        {
            List<int> actual = TreeIntersection(null, new BinaryTree<int>());
            Assert.Null(actual);
        }

        [Fact]
        public void testTreeIntersectionNoRootOne()
        {
            BinaryTree<int> one = new BinaryTree<int>();
            BinaryTree<int> two = new BinaryTree<int> { Root = new Node<int> { Data = 1 } };
            List<int> actual = TreeIntersection(one, two);
            Assert.Null(actual);
        }

        [Fact]
        public void testTreeIntersectionNoRootTwo()
        {
            BinaryTree<int> one = new BinaryTree<int> { Root = new Node<int> { Data = 1 } };
            BinaryTree<int> two = new BinaryTree<int>();
            List<int> actual = TreeIntersection(one, two);
            Assert.Null(actual);
        }

        [Fact]
        public void testTreeIntersectionNoShared()
        {
            BinaryTree<int> one = new BinaryTree<int> { Root = new Node<int> { Data = 1, Right = new Node<int> { Data = 3 } } };
            BinaryTree<int> two = new BinaryTree<int> { Root = new Node<int> { Data = 2, Right = new Node<int> { Data = 4 } } };
            List<int> actual = TreeIntersection(one, two);
            Assert.Empty(actual);
        }

        [Fact]
        public void testTreeIntersectionShares()
        {
            BinaryTree<int> one = new BinaryTree<int> { Root = new Node<int> { Data = 1, Right = new Node<int> { Data = 4 } } };
            BinaryTree<int> two = new BinaryTree<int> { Root = new Node<int> { Data = 2, Right = new Node<int> { Data = 4 } } };
            List<int> actual = TreeIntersection(one, two);
            Assert.Contains(4, actual);
        }

        [Fact]
        public void testHash()
        {
            Table table = new Table(1024);
            int hash = table.Hash("a");
            Assert.Equal(131, hash);
        }

        [Fact]
        public void testAdd()
        {
            Table table = new Table(1024);
            Entry entry = null;
            table.Add("test", "test value");
            for (int i = 0; i < table.Map.Length; i++)
            {
                if (table.Map[i] != null)
                {
                    entry = table.Map[i].First.Value;
                }
            }
            Assert.Equal("test value", entry.Value);
        }

        [Fact]
        public void testGetEntry()
        {
            Table table = new Table(1024);
            Entry entry = null;
            table.Add("test", "test value");
            entry = table.Get("test");
            Assert.Equal("test value", entry.Value);
        }

        [Fact]
        public void testGetNull()
        {
            Table table = new Table(1024);
            table.Add("test", "test value");
            Entry entry = table.Get("null");
            Assert.Null(entry);
        }

        [Fact]
        public void testContainsTrue()
        {
            Table table = new Table(1024);
            table.Add("test", "test value");
            Assert.True(table.Contains("test"));
        }

        [Fact]
        public void testContainsFalse()
        {
            Table table = new Table(1024);
            table.Add("test", "test value");
            Assert.False(table.Contains("false"));
        }

    }
}
