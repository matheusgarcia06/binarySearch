using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 10;
            array[2] = 20;
            array[3] = 30;
            array[4] = 35;

            int posicaoFinal = array.Length - 1;
            BinarySearch(array, 20, 0, posicaoFinal);

        }

        static int BinarySearch(int[] array, int item, int begin, int end)
        {
            if (begin <= end)
            {
                int mid = (begin + end) / 2;
                if (array[mid] == item)
                {
                    return mid;
                }
                if (item < array[mid])
                {
                    return BinarySearch(array, item, begin, mid - 1);
                } else
                {
                    return BinarySearch(array, item, mid + 1, end);
                }
            }
            return -1;
        }
    }
}
