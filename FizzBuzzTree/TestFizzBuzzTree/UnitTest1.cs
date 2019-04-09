using System;
using Trees.Classes;
using FizzBuzzTree;
using Xunit;

namespace TestFizzBuzzTree
{
    public class UnitTest1
    {
        [Fact]
        public void TestFizzBuzzTree()
        {
            BinaryTree<object> tree = new BinaryTree<object> { Root = new Node<object> { Data = 5, Left = new Node<object> { Data = 3, Left = null, Right = null }, Right = new Node<object> { Data = 15, Left = null, Right = null } } };
            tree = Program.FizzBuzz(tree);
            Assert.Equal("Buzz", tree.Root.Data);
            Assert.Equal("Fizz", tree.Root.Left.Data);
            Assert.Equal("FizzBuzz", tree.Root.Right.Data);
        }

        [Fact]
        public void TestFizzBuzzTreeNoChange()
        {
            BinaryTree<object> tree = new BinaryTree<object> { Root = new Node<object> { Data = 2, Left = new Node<object> { Data = 0, Left = null, Right = null }, Right = new Node<object> { Data = 1, Left = null, Right = null } } };
            tree = Program.FizzBuzz(tree);
            Assert.Equal(2, tree.Root.Data);
            Assert.Equal(0, tree.Root.Left.Data);
            Assert.Equal(1, tree.Root.Right.Data);
        }
    }
}
