using System;
using System.Collections.Generic;
using System.Text;

namespace sorting
{
    public class QuickSorter : ISorter
    {
        public void SortElements(int[] elements)
        {
            this.QuickSort(elements, 0, elements.Length - 1);
        }

        private void QuickSort(int[] elements, int low, int high)
        {
            if (low >= high)
                return;

            int pivotIndex = this.Partition(elements, low, high);
            this.QuickSort(elements, low, pivotIndex - 1);
            this.QuickSort(elements, pivotIndex + 1, high);
        }

        private int Partition(int[] elements, int low, int high)
        {
            int l = low;
            int h = high;
            int pivot = elements[low];

            while (l < h)
            {
                while (elements[l] <= pivot && l < h)
                    l++;

                while (elements[h] > pivot)
                    h--;

                if (l < h)
                    Util.SwapElements<int>(elements, l, h);
            }

            Util.SwapElements<int>(elements, low, h);
            return h;
        }
    }
}
