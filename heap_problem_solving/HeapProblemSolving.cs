using heap;
using System;

namespace heap_problem_solving
{
    public class HeapProblemSolving
    {
        public static T FindMaximumElementInAMinHeap<T>(MinHeap<T> minimumHeap) where T : IComparable
        {

            int lastElementIndex = minimumHeap.GetCount() - 1;

            if (lastElementIndex < 0)
                return default(T);

            if (lastElementIndex.Equals(0))
                return minimumHeap.GetElementAtIndex(0);

            int lastParentIndex = minimumHeap.GetParentIndex(lastElementIndex);
            int firstLeafIndex = lastParentIndex + 1;

            T maxElement = minimumHeap.GetElementAtIndex(firstLeafIndex);

            for (int i = firstLeafIndex + 1; i <= lastElementIndex; i++)
            {
                T currentElement = minimumHeap.GetElementAtIndex(i);
                maxElement = maxElement.CompareTo(currentElement) < 0 ? currentElement : maxElement;
            }

            return maxElement;

        }

        public static T[] FindMaximumKElementsInASequence<T>(T[] sequence, int k) where T : IComparable
        {
            T[] result = new T[k];
            MinHeap<T> minHeap = new MinHeap<T>(k);

            if (k <= 0)
                return result;

            for (int i = 0; i < k; i++)
            {
                minHeap.Insert(sequence[i]);
            }

            for (int i = k; i < sequence.Length; i++)
            {
                if (minHeap.GetElementAtIndex(0).CompareTo(sequence[i]) < 0)
                {
                    minHeap.Remove();
                    minHeap.Insert(sequence[i]);
                }
            }

            for (int i = 0; i < k; i++)
            {
                result[i] = minHeap.Remove();
            }

            return result;

        }
    }
}
