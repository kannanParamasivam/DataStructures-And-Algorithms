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

        /// <summary>
        /// This is applicable for the inputs coming from the source like keyboard but we are not sure about what 
        /// is gonna come in
        /// </summary>
        [Fact]
        public void FindMaximumKElementsInASequence_WhenCalled_ShouldReturnMaximumKElement()
        {
            int[] data = new int[] { 5, 8, 6, 9, 12, 11, 7, 15, 10 };
            int[] actualResult = HeapProblemSolving.FindMaximumKElementsInASequence(sequence: data, k: 5);
            int[] expectedResult = new int[] { 15, 12, 11, 10, 9 };
            Assert.True(!expectedResult.Except<int>(actualResult).Any());
        }

        [Fact]
        public void FindMaximumKElementsInASequence_WhenKIsZero_ShouldReturnEmptyResult()
        {
            int[] data = new int[] { 5, 8, 6, 9, 12, 11, 7, 15, 10 };
            int[] result = HeapProblemSolving.FindMaximumKElementsInASequence(sequence: data, k: 0);

            Assert.Equal(new int[] { }, result);
        }

    }
}
