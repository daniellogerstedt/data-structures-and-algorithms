using System;
using Xunit;
using StacksAndQueues.Classes;

namespace TestStacksAndQueues
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmptyStack()
        {
            Stack<string> stack = new Stack<string>();
            Assert.Null(stack.Top);
        }

        [Fact]
        public void TestEmptyQueue()
        {
            Queue<string> queue = new Queue<string>();
            Assert.Null(queue.Front.Top);
            Assert.Null(queue.Back.Top);
        }

        [Fact]
        public void TestPushValue()
        {
            Stack<string> stack = new Stack<string>();
            Assert.Null(stack.Top);
            stack.Push("Test");
            Assert.Equal("Test", stack.Top.Data);

        }

        [Fact]
        public void TestPushNode()
        {
            Stack<string> stack = new Stack<string>();
            Assert.Null(stack.Top);
            Node<string> node = new Node<string> { Next = null, Data = "Test" };
            stack.Push(node);
            Assert.Equal(node, stack.Top);
        }

        [Fact]
        public void TestPop()
        {
            Stack<string> stack = new Stack<string>();
            Node<string> node = new Node<string> { Next = null, Data = "Test" };
            stack.Push(node);
            Assert.Equal(node, stack.Pop());
            Assert.Null(stack.Top);
        }

        [Fact]
        public void TestEnqueue()
        {
            Queue<string> queue = new Queue<string>();
            Assert.Null(queue.Front.Top);
            Assert.Null(queue.Back.Top);
            queue.Enqueue("Test");
            Assert.Null(queue.Front.Top);
            Assert.Equal("Test", queue.Back.Top.Data);
        }

        [Fact]
        public void TestDequeue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Test");
            Assert.Equal("Test", queue.Dequeue().Data);
            Assert.Null(queue.Front.Top);
            Assert.Null(queue.Back.Top);
        }

        [Fact]
        public void TestPeekStack()
        {
            Stack<string> stack = new Stack<string>();
            Node<string> node = new Node<string> { Next = null, Data = "Test" };
            stack.Push(node);
            Assert.Equal(node, stack.Peek());
            Assert.NotNull(stack.Top);

        }

        [Fact]
        public void TestPeekQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Test");
            Assert.Equal("Test", queue.Peek().Data);
            Assert.NotNull(queue.Front.Top);
        }


        [Fact]
        public void TestPeekStackNull()
        {
            Stack<string> stack = new Stack<string>();
            Assert.Null(stack.Peek());
        }

        [Fact]
        public void TestPeekQueueNull()
        {
            Queue<string> queue = new Queue<string>();
            Assert.Null(queue.Peek());
        }
    }
}
