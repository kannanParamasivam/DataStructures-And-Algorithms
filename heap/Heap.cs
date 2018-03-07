using System;

namespace heap
{
    public abstract class Heap<T> where T : IComparable
    {
        static int MAX_SIZE = 40;
        T[] array;
        int count = 0;

        public Heap(int size) => array = new T[size];

        public Heap() : this(size: MAX_SIZE) { }

        public int GetLeftChildIndex(int index)
        {
            int leftChildIndex = (2 * index) + 1;
            return leftChildIndex >= count ? -1 : leftChildIndex;
        }

        public int GetRightChildIndex(int index)
        {
            int rightChildIndex = (2 * index) + 2;
            return rightChildIndex >= count ? -1 : rightChildIndex;
        }

        public int GetParentIndex(int index)
        {
            int parentIndex = (index - 1) / 2;
            return parentIndex < 0 || parentIndex > count ? -1 : parentIndex;
        }

        protected void Swap(int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public int GetCount()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == array.Length;
        }

        public T GetElementAtIndex(int index)
        {
            return array[index];
        }

        public void Insert(T value)
        {
            if (this.IsFull())
                throw new HeapFullException();

            array[count] = value;
            ShiftUp(count);
            count++;
        }

        private T GetHighestPriorityElement()
        {
            if (this.IsEmpty())
                throw new HeapEmptyException();

            return array[0];
        }

        public T Remove()
        {
            T highestPriorityElement = this.GetHighestPriorityElement();
            array[0] = array[count - 1];
            count--;
            this.ShiftDown(0);
            return highestPriorityElement;
        }

        public abstract void ShiftDown(int index);

        public abstract void ShiftUp(int index);
    }
}
