using System;

namespace queue
{
    public class Queue<T> : IQueue<T>
    {
        private const int SPECIAL_EMPTY_VALUE = -1;
        private Array elements;
        private int MAX_SIZE = 30;

        private int headIndex = SPECIAL_EMPTY_VALUE;
        private int tailIndex = SPECIAL_EMPTY_VALUE;

        public Array CircularArray { get { return elements; } }

        public Queue()
        {
            elements = Array.CreateInstance(typeof(T), this.MAX_SIZE);
        }

        /// <summary>
        /// Complexity is O(1)
        /// </summary>
        /// <param name="data"></param>
        public void ENQUEUE(T data)
        {
            if (this.IsFull())
                throw new QueueOverflowException();


            int nextIndex = GetCircularNextIndex(tailIndex + 1);
            CircularArray.SetValue(data, nextIndex);

            this.tailIndex = nextIndex;

            if (headIndex == SPECIAL_EMPTY_VALUE)
            {
                headIndex = tailIndex;
            }
        }

        private int GetCircularNextIndex(int directNextIndex)
        {
            return directNextIndex > (MAX_SIZE - 1) ? directNextIndex - (MAX_SIZE - 1) : directNextIndex;
        }

        /// <summary>
        /// Complexity is O(1)
        /// </summary>
        /// <returns></returns>
        public T DEQUEUE()
        {
            if (this.IsEmpty())
                throw new QueueUnderflowException();

            T data = (T)elements.GetValue(headIndex);

            if (headIndex == tailIndex)
            {
                headIndex = SPECIAL_EMPTY_VALUE;
            }
            else
            {
                headIndex = this.GetCircularNextIndex(headIndex+1);
            }

            return data;
        }

        public bool IsEmpty()
        {
            return this.headIndex == -1;
        }

        /// <summary>
        /// When head index is next to tail index, queue is full
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            if (this.headIndex == -1)
            {
                return false;
            }
            else
            {
                int expectedHeadIndex = (tailIndex + 1) > (elements.Length - 1) ?
                (tailIndex + 1) - (elements.Length) : (tailIndex + 1);
                return expectedHeadIndex == this.headIndex;
            }
        }

        public bool OFFER()
        {
            throw new NotImplementedException();
        }

        public T PEEK()
        {
            if (this.IsEmpty())
                throw new QueueUnderflowException();

            return (T)elements.GetValue(headIndex);
        }

        public bool IsSingleElementPresent()
        {
            if (headIndex == SPECIAL_EMPTY_VALUE && tailIndex == SPECIAL_EMPTY_VALUE)
                return false;

            return headIndex == tailIndex;
        }
    }
}
