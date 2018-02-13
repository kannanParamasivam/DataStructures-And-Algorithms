using System;
using System.Collections.Generic;
using System.Text;

namespace sorting
{
    public class BubbleSorter : ISorter
    {
        public void SortElements(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                bool swapped = false;
                for (int j = elements.Length - 1; j > i; j--)
                {
                    if (elements[j] < elements[j - 1])
                    {
                        Util.SwapElements<int>(elements, j, j - 1);
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }
        }
    }
}
