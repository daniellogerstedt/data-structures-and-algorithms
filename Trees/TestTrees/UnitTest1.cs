using System;
using Xunit;
using Trees.Classes;
using System.Collections.Generic;
using System.Text;

namespace TestTrees
{
    public class UnitTest1
    {
        [Fact]
        public void TestPreOrder()
        {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Root = new Node<string>()
            {
                Data = "root",
                Left = new Node<string> { Data = "left", Left = null, Right = null },
                Right = new Node<string>() { Data = "right", Left = null, Right = null }
            };
            List<string> list = tree.PreOrder();
            string[] array = list.ToArray();
            Assert.Equal("root", array[0]);
            Assert.Equal("left", array[1]);
            Assert.Equal("right", array[2]);
        }

        [Fact]
        public void TestInOrder()
        {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Root = new Node<string>()
            {
                Data = "root",
                Left = new Node<string> { Data = "left", Left = null, Right = null },
                Right = new Node<string>() { Data = "right", Left = null, Right = null }
            };
            List<string> list = tree.InOrder();
            string[] array = list.ToArray();
            Assert.Equal("left", array[0]);
            Assert.Equal("root", array[1]);
            Assert.Equal("right", array[2]);
        }

        [Fact]
        public void TestPostOrder()
        {
            BinaryTree<string> tree = new BinaryTree<string>();
            tree.Root = new Node<string>()
            {
                Data = "root",
                Left = new Node<string> { Data = "left", Left = null, Right = null },
                Right = new Node<string>() { Data = "right", Left = null, Right = null }
            };
            List<string> list = tree.PostOrder();
            string[] array = list.ToArray();
            Assert.Equal("left", array[0]);
            Assert.Equal("right", array[1]);
            Assert.Equal("root", array[2]);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(5)]
        [InlineData(25)]
        [InlineData(15)]
        [InlineData(17)]
        public void TestAddBST(int test)
        {
            List<int> expected = new List<int>();
            BST<int> bst = new BST<int>();
            Random rand = new Random();
            int newRand = rand.Next();
            expected.Add(newRand);
            bst.AddNode(newRand);
            for (int i = 0; i < test; i++)
            {
                newRand = rand.Next();
                expected.Add(newRand);
                bst.AddNode(newRand);
            }
            List<int> actual = bst.InOrder();
            int[] act = actual.ToArray();
            int[] exp = expected.ToArray();
            Array.Sort(exp);
            Assert.Equal(exp, act);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(5)]
        [InlineData(25)]
        [InlineData(15)]
        [InlineData(17)]
        public void TestContainsBST(int test)
        {
            List<int> expected = new List<int>();
            BST<int> bst = new BST<int>();
            Random rand = new Random();
            int newRand = rand.Next();
            expected.Add(newRand);
            bst.AddNode(newRand);
            for (int i = 0; i < test; i++)
            {
                newRand = rand.Next();
                expected.Add(newRand);
                bst.AddNode(newRand);
            }
            newRand = rand.Next();
            bool exp = expected.Contains(newRand);
            bool act = bst.Contains(newRand);
            Assert.Equal(exp, act);
        }



    }
}
