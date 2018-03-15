using heap;
using System;
using Xunit;

namespace heap_test
{
    public class MinHeapTest
    {
        MinHeap<int> minHeap;
        public MinHeapTest()
        {
            //minHeap = new MinHeap<int>(3);
        }

        [Fact]
        public void Insert_WhenCalled_ShouldInsertElementsInMinHeapOrder()
        {
            minHeap = new MinHeap<int>(3);
            int[] input = new int[] { 2, 3, 1 };

            foreach (int item in input)
                minHeap.Insert(item);

            int[] output = new int[3];

            for (int i = 0; i < minHeap.GetCount(); i++)
                output[i] = minHeap.GetElementAtIndex(i);

            Assert.Equal(new int[] { 1, 3, 2 }, output);
        }
    }
}
