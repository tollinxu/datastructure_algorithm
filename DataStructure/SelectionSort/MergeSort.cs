using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
    public class MergeSort<T> where T : IComparable
    {
        public static T[] Sort(T[] array)
        {
            var length = array.Length;
            _MergeSort(0, length - 1, array);
            return array;
        }

        private static void _MergeSort(int left, int right, T[] array)
        {
            if (left >= right)
            {
                return;
            }
            int mid = (right - left) / 2 + left;
            _MergeSort(left, mid, array);
            _MergeSort(mid + 1, right, array);

            Sort(left, right, array);

        }

        private static void Sort(int left, int right, T[] array)
        {
            int length = right - left + 1;
            var copyArray = new T[length];
            for (int k = left; k <= right; k++)
            {
                copyArray[k - left] = array[k];
            }
            int i = left;
            int mid = (right - left) / 2 + left;
            int j = (right - left)/ 2 + left + 1;
            for(int k = left; k <= right; k++)
            {
                if(i > mid)
                {
                    array[k] = copyArray[j - left];
                    j++;
                    continue;
                }
                if (j > right)
                {
                    array[k] = copyArray[i - left];
                    i++;
                    continue;
                }
                if (copyArray[i-left].CompareTo(copyArray[j - left]) > 0)
                {
                    array[k] = copyArray[j - left];
                    j++;
                }
                else
                {
                    array[k] = copyArray[i - left];
                    i++;
                }               
            }
        }
    }
}
