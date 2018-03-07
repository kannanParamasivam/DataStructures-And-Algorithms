using heap_sort;
using System;
using System.Linq;
using Xunit;

namespace heap_sort_test
{
    public class HeapSortTest
    {
        [Fact]
        public void GetLeftChildIndex_WhenNoLeafNode_ShouldReturnNegative()
        {
            int[] data = { 5, 7, 3, 9, 1, 6, 10, 2, 4, 8 };

            Assert.Equal(-1, HeapSort.GetLeftChildIndex(index: 6, endIndex: 9));
        }

        [Fact]
        public void GetLeftChildIndex_WhenCalled_ShouldReturnLeftChildOfTheEelement()
        {
            int[] data = { 5, 7, 3, 9, 1, 6, 10, 2, 4, 8 };

            Assert.Equal(5, HeapSort.GetLeftChildIndex(index: 2, endIndex: 9));
        }

        [Fact]
        public void GetRightChildIndex_WhenNoLeafNode_ShouldReturnNegative()
        {
            int[] data = { 5, 7, 3, 9, 1, 6, 10, 2, 4, 8 };

            Assert.Equal(-1, HeapSort.GetRightChildIndex(index: 6, endIndex: 9));
        }

        [Fact]
        public void GetRightChildIndex_WhenCalled_ShouldReturnLeftChildOfTheEelement()
        {
            int[] data = { 5, 7, 3, 9, 1, 6, 10, 2, 4, 8 };

            Assert.Equal(6, HeapSort.GetRightChildIndex(index: 2, endIndex: 9));
        }

        [Fact]
        public void GetParentIndex_WhenCalledWithIndexZero_ShouldReturnNegative()
        {
            Assert.Equal(-1, HeapSort.GetParentIndex(index: 0, endIndex: 9));
        }

        [Fact]
        public void GetParentIndex_WhenCalledWithIndexMoreThanEndIndex_ShouldReturnNegative()
        {
            Assert.Equal(-1, HeapSort.GetParentIndex(index: 10, endIndex: 9));
        }

        [Fact]
        public void GetParentIndex_WhenCalled_ShouldReturnParentElementIndex()
        {
            int[] data = { 5, 7, 3, 9, 1, 6, 10, 2, 4, 8 };
            Assert.Equal(2, HeapSort.GetParentIndex(index: 6, endIndex: 9));
        }

        [Fact]
        public void Swap_WhenAnyIndexIsOutOfBound_ShouldNotMakeAnyChanges()
        {
            int[] array = { 5, 7, 3, 9, 1, 6, 10, 2, 4, 8 };
            HeapSort.Swap(array: array, index1: -1, index2: 3);
            Assert.Equal(new int[] { 5, 7, 3, 9, 1, 6, 10, 2, 4, 8 }, array);
        }

        [Fact]
        public void Swap_WhenIndexesAreValid_ShouldSwapTheElements()
        {
            int[] array = { 5, 7, 3, 9, 1, 6, 10, 2, 4, 8 };
            HeapSort.Swap(array: array, index1: 2, index2: 4);
            Assert.Equal(new int[] { 5, 7, 1, 9, 3, 6, 10, 2, 4, 8 }, array);
        }

        [Fact]
        public void PercolateDown_WhenCalledWithValidIndex_ShouldPerColateDown()
        {
            int[] array = { 5, 7, 3, 9, 1, 6, 10, 2, 4, 8 };
            HeapSort.PercolateDown(array: array, index: 0, endIndex: 9);
            Assert.Equal(new int[] { 7, 9, 3, 5, 1, 6, 10, 2, 4, 8 }, array);
        }

        [Fact]
        public void Heapify_WhenCalledWithData_ShouldHeapifyTheData()
        {
            int[] array = { 5, 7, 3, 9, 1, 6, 10, 2, 4, 8 };
            HeapSort.Heapify(array: array, endIndex: 9);
            Assert.Equal(new int[] { 10, 8, 9, 5, 7, 3, 6, 2, 4, 1 }, array);
        }

        [Fact]
        public void HeapSort_WhenCalled_ShouldSortTheArray()
        {
            int[] array = { 5, 7, 3, 9, 1, 6, 10, 2, 4, 8 };
            HeapSort.Sort(array: array);
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, array);
        }



    }
}
