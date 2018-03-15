using heap;
using heap_problem_solving;
using System;
using System.Linq;
using Xunit;

namespace heap_problem_solving_test
{
    public class HeapProblemSolvingTest
    {
        [Fact]
        public void FindMaximumElementInAMinHeap_WhenMinHeapIsEmpty_ShouldReturnDefaultValue()
        {
            MinHeap<int> minHeap = new MinHeap<int>();
            Assert.Equal(0, HeapProblemSolving.FindMaximumElementInAMinHeap<int>(minimumHeap: minHeap));
        }

        [Fact]
        public void FindMaximumElementInAMinHeap_WhenMinHeapHasOnlyOneElement_ShouldReturnTheAvailableElement()
        {
            MinHeap<int> minHeap = new MinHeap<int>();
            minHeap.Insert(3);
            Assert.Equal(3, HeapProblemSolving.FindMaximumElementInAMinHeap<int>(minimumHeap: minHeap));
        }

        [Fact]
        public void FindMaximumElementInAMinHeap_WhenMinHeapProvided_ShouldReturnMaximumElement()
        {
            int[] data = new int[] { 5, 8, 6, 9, 12, 11, 7, 15, 10 };

            MinHeap<int> minHeap = new MinHeap<int>();
            data.ToList().ForEach(val => minHeap.Insert(val));

            Assert.Equal(15, HeapProblemSolving.FindMaximumElementInAMinHeap<int>(minimumHeap: minHeap));
        }


    }
}
