using System;
using System.Diagnostics;

namespace sorting
{
    public class Util
    {
        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                //Console.WriteLine(Convert.ToSingle(item));
                Debug.WriteLine(Convert.ToString(item));
            }

            //Console.WriteLine();
            Debug.WriteLine(String.Empty);
        }

        public static void SwapElements<T>(T[] array, int firstIndex, int secondIndex)
        {
            T temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

        public static void Split(int[] elementList, int[] listFirstHalf, int[] listSecondHalf)
        {
            int secondHalfStartIndex = listFirstHalf.Length;

            for (int i = 0; i < elementList.Length; i++)
            {
                if (i < secondHalfStartIndex)
                    listFirstHalf[i] = elementList[i];
                else
                    listSecondHalf[i - secondHalfStartIndex] = elementList[i];
            }
        }

        public static void Merge(int[] elementsList, int[] listFirstHalf, int[] listSecondHalf)
        {
            int mergeIndex = 0;
            int firstHalfIndex = 0;
            int secondHalfIndex = 0;

            while (firstHalfIndex < listFirstHalf.Length && secondHalfIndex < listSecondHalf.Length)
            {
                if (listFirstHalf[firstHalfIndex] < listSecondHalf[secondHalfIndex])
                {
                    elementsList[mergeIndex] = listFirstHalf[firstHalfIndex];
                    firstHalfIndex++;
                }
                else if (listFirstHalf[firstHalfIndex] > listSecondHalf[secondHalfIndex])
                {
                    elementsList[mergeIndex] = listSecondHalf[secondHalfIndex];
                    secondHalfIndex++;
                }
                mergeIndex++;
            }

            if (firstHalfIndex < listFirstHalf.Length)
            {
                while (mergeIndex < elementsList.Length)
                {
                    elementsList[mergeIndex++] = listFirstHalf[firstHalfIndex++];
                }
            }

            if (secondHalfIndex < listSecondHalf.Length) {
                while (mergeIndex<elementsList.Length)
                {
                    elementsList[mergeIndex++] = listSecondHalf[secondHalfIndex++];
                }
            }
        }

    }
}
