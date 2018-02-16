using System;
using System.Collections.Generic;
using System.Text;

namespace sorting
{
    public class MergeSorter : ISorter
    {
        public void SortElements(int[] elements)
        {
            if (elements.Length == 1)
                return;

            int middleIndex = (elements.Length / 2) + (elements.Length % 2);
            int[] listFirstHalf = new int[middleIndex];
            int[] listSecondHalf = new int[elements.Length - middleIndex];

            Util.Split(elements, listFirstHalf, listSecondHalf);

            SortElements(listFirstHalf);
            SortElements(listSecondHalf);

            Util.Merge(elements, listFirstHalf, listSecondHalf);
        }
    }
}
