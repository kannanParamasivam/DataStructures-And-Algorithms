using queue;
using System;
using Xunit;

namespace queue_test
{
    public class QueueTest
    {
        IQueue<string> queue;

        public QueueTest()
        {
            queue = new Queue<string>();
        }

        [Fact]
        public void IsEmpty_WhenEmpty_ShouldReturnTrue()
        {
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void IsEmpty_WhenNotEmpty_ShouldReturFalse()
        {
            queue.ENQUEUE("first element");
            Assert.False(queue.IsEmpty());
        }

        [Fact]
        public void IsFull_WhenEmpty_ShouldReturenFalse()
        {
            Assert.False(queue.IsFull());
        }

        [Fact]
        public void ENQUEUE_WhenCalled_ShouldInsertValue()
        {
            queue.ENQUEUE("first element");
            Assert.False(queue.IsEmpty());
            Assert.True(queue.IsSingleElementPresent());
        }

        [Fact]
        public void ENQUEUE_WhenQueueIsFull_ShouldThrowQueueOverflowException()
        {

            for (int i = 0; i < 30; i++)
            {
                queue.ENQUEUE(i.ToString());
            }

            Assert.Throws<QueueOverflowException>(() => queue.ENQUEUE("new element"));
        }

        [Fact]
        public void PEEK_WhenQueueIsEmpty_ShoudThrowQueueUnderflowException()
        {
            Assert.Throws<QueueUnderflowException>(() => queue.PEEK());
        }

        [Fact]
        public void PEEK_WhenNotEmpty_ShoudReturenValueInHead()
        {
            string firstElement = "first element";
            string secondElement = "second element";
            queue.ENQUEUE(firstElement);
            queue.ENQUEUE(secondElement);
            Assert.Equal(firstElement, queue.PEEK());
        }

        [Fact]
        public void DEQUEUE_WhenNotEmpty_ShouldDequeueElementInHead()
        {
            string firstElement = "first element";
            string secondElement = "second element";
            queue.ENQUEUE(firstElement);
            queue.ENQUEUE(secondElement);
            Assert.Equal(firstElement, queue.DEQUEUE());
            Assert.Equal(secondElement, queue.DEQUEUE());
        }

        [Fact]
        public void DEQUEUE_WhenAllElementsDEQUEUEd_ShouldBeEmpty()
        {
            string firstElement = "first element";
            string secondElement = "second element";
            queue.ENQUEUE(firstElement);
            queue.ENQUEUE(secondElement);
            Assert.Equal(firstElement, queue.DEQUEUE());
            Assert.Equal(secondElement, queue.DEQUEUE());
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void DEQUEUE_WhenEmpty_ShouldThrowStackUnderflow()
        {
            Assert.Throws<QueueUnderflowException>(() => queue.DEQUEUE());
        }
    }
}
