using System;
using System.Collections.Generic;
using System.Text;

namespace sorting
{
    public class ShellSorter : ISorter
    {
        public void SortElements(int[] elements)
        {
            int increment = elements.Length / 2;

            while (increment>=1)
            {
                for (int startIndex = 0; startIndex < increment; startIndex++)
                {
                    this.ModifiedInsertionSort(elements, startIndex, increment);
                }

                increment = increment / 2;
            }
        }

        private void ModifiedInsertionSort(int[] elements, int startIndex, int increment)
        {
            Util.PrintArray<int>(elements);
            for (int i = startIndex; i < elements.Length; i = i + increment)
            {
                for (int j = Math.Min(i + increment, elements.Length - 1);
                    j - increment >= 0;
                    j = j - increment)
                {
                    if (elements[j - increment] > elements[j])
                    {
                        Util.SwapElements<int>(elements, j - 1, j);
                    }
                    else
                    {
                        break;
                    }

                    Util.PrintArray<int>(elements);
                }
            }
        }
    }
}
