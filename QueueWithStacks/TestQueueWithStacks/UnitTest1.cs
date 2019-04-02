using System;
using Xunit;
using QueueWithStacks.Classes;
using StacksAndQueues.Classes;

namespace TestQueueWithStacks
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmptyQueue()
        {
            PseudoQueue<string> queue = new PseudoQueue<string>();
            Assert.Null(queue.Front.Top);
            Assert.Null(queue.Back.Top);
        }

        [Fact]
        public void TestEnqueue()
        {
            PseudoQueue<string> queue = new PseudoQueue<string>();
            Assert.Null(queue.Front.Top);
            Assert.Null(queue.Back.Top);
            queue.Enqueue("Test");
            Assert.Null(queue.Front.Top);
            Assert.Equal("Test", queue.Back.Top.Data);
        }

        [Fact]
        public void TestDequeue()
        {
            PseudoQueue<string> queue = new PseudoQueue<string>();
            queue.Enqueue("Test");
            Assert.Equal("Test", queue.Dequeue().Data);
            Assert.Null(queue.Front.Top);
            Assert.Null(queue.Back.Top);
        }

        [Fact]
        public void TestPeekQueue()
        {
            PseudoQueue<string> queue = new PseudoQueue<string>();
            queue.Enqueue("Test");
            Assert.Equal("Test", queue.Peek().Data);
            Assert.NotNull(queue.Front.Top);
        }

        [Fact]
        public void TestPeekQueueNull()
        {
            PseudoQueue<string> queue = new PseudoQueue<string>();
            Assert.Null(queue.Peek());
        }
    }
}

