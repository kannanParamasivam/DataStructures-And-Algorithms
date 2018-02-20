using search;
using System;

namespace Search
{
    public class BinarySearch : ISearch
    {
        public int Search(int[] elements, int elementToFind)
        {
            int min = 0;
            int max = elements.Length - 1;

            while (min <= max)
            {
                int mid = min + (max - min) / 2;

                if (elements[mid] == elementToFind)
                    return mid;

                if (elementToFind < elements[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }

            return -1;
        }
    }
}
