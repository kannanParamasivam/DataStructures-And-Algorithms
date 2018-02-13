using System;

namespace sorting
{
    public class Util
    {
        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(Convert.ToSingle(item));
            }

            Console.WriteLine();
        }

        public static void SwapElements<T>(T[] array, int firstIndex, int secondIndex)
        {
            T temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
    }
}
