using System;
using System.Collections.Generic;

namespace heap_sort
{
    public class HeapSort
    {
        public static int GetLeftChildIndex(int index, int endIndex)
        {
            int leftChildIndex = (index * 2) + 1;
            return leftChildIndex > endIndex ? -1 : leftChildIndex;
        }

        public static int GetRightChildIndex(int index, int endIndex)
        {
            int rightChildIndex = (index * 2) + 2;
            return rightChildIndex > endIndex ? -1 : rightChildIndex;
        }

        public static int GetParentIndex(int index, int endIndex)
        {
            if (index <= 0 || index > endIndex)
                return -1;

            return (index - 1) / 2;
        }

        public static void Swap(int[] array, int index1, int index2)
        {
            if (index1 < 0 || index1 >= array.Length || index2 < 0 || index2 >= array.Length)
                return;

            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public static void PercolateDown(int[] array, int index, int endIndex)
        {
            int leftChildIndex = GetLeftChildIndex(index, endIndex);
            int rightChildIndex = GetRightChildIndex(index, endIndex);

            if (leftChildIndex != -1 && array[leftChildIndex] > array[index])
            {
                Swap(array, leftChildIndex, index);
                PercolateDown(array, leftChildIndex, endIndex);
            }

            if (rightChildIndex != -1 && array[rightChildIndex] > array[index])
            {
                Swap(array, rightChildIndex, index);
                PercolateDown(array, rightChildIndex, endIndex);
            }
        }

        public static void Heapify(int[] array, int endIndex)
        {
            int index = GetParentIndex(endIndex, endIndex);
            while (index >= 0)
            {
                PercolateDown(array, index, endIndex);
                index--;
            }
        }

        public static void Sort(int[] array)
        {
            Heapify(array, array.Length - 1);
            int endIndex = array.Length - 1;

            while (endIndex > 0)
            {
                Swap(array, 0, endIndex);
                endIndex--;
                PercolateDown(array, 0, endIndex);
            }
        }
    }
}
