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
    }
}
