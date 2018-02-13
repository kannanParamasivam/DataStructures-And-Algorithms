using System;
using System.Collections.Generic;
using System.Text;

namespace sorting
{
    public class InsertionSorter : ISorter
    {
        public void SortElements(int[] elements)
        {
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (elements[j - 1] > elements[j])
                        Util.SwapElements<int>(elements, j - 1, j);
                    else
                        break;
                }
            }
        }
    }
}
