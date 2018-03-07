using System;
using System.Collections.Generic;
using System.Text;

namespace heap
{
    public class MinHeap<T> : Heap<T> where T : IComparable
    {
        public MinHeap() : base() { }

        public MinHeap(int size) : base(size) { }

        public override void ShiftDown(int index)
        {
            int leftChildIndex = this.GetLeftChildIndex(index);
            int rightChildIndex = this.GetRightChildIndex(index);

            if (leftChildIndex == -1 && rightChildIndex == -1)
                return;

            int smallerIndex = -1;

            smallerIndex = GetSmallerValueIndex(leftChildIndex, rightChildIndex);

            if (smallerIndex == -1)
                return;

            if (GetElementAtIndex(smallerIndex).CompareTo(GetElementAtIndex(index)) < 0)
            {
                this.Swap(smallerIndex, index);
                ShiftDown(smallerIndex);
            }

        }

        public override void ShiftUp(int index)
        {
            if (index <= 0)
                return;

            int parentIndex = this.GetParentIndex(index);

            if (GetElementAtIndex(index).CompareTo(GetElementAtIndex(parentIndex)) < 0)
            {
                Swap(index, parentIndex);
                ShiftUp(parentIndex);
            }
        }

        private int GetSmallerValueIndex(int leftChildIndex, int rightChildIndex)
        {
            if (leftChildIndex != -1 && rightChildIndex != -1)
            {
                return this.GetElementAtIndex(leftChildIndex)
                    .CompareTo(GetElementAtIndex(rightChildIndex)) < 0 ?
                    leftChildIndex : rightChildIndex;
            }
            else if (leftChildIndex != -1)
            {
                return leftChildIndex;
            }
            else if (rightChildIndex != -1)
            {
                return rightChildIndex;
            }
            return -1;
        }

    }
}
