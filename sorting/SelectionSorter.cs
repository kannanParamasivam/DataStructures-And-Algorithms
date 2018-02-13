using System;
using System.Collections.Generic;
using System.Text;

namespace sorting
{
    public class SelectionSorter : ISorter
    {
        public void SortElements(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i+1; j < elements.Length; j++)
                {
                    if (Convert.ToInt32(elements[i]) > Convert.ToInt32(elements[j]))
                    {
                        Util.SwapElements<int>(elements, i, j);
                    }
                }
            }
        }
    }
}
