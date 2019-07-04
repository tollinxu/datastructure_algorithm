using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
    public class GenericSelectionSort
    {
        public static T[] SelectionSort<T>(T[] array) where T : IComparable
        {
            int lenght = array.Length;
            int minIndex = 0;
            for (int i = 0; i < lenght; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < lenght; j++)
                {
                    if (array[minIndex].CompareTo( array[j]) > 0)
                    {
                        T temp = array[minIndex];
                        array[minIndex] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }

    public class Student : IComparable
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public int CompareTo(object obj)
        {
            var std = obj as Student;
            if(std == null)
            {
                return -1;
            }

            return this.Score - std.Score;
        }
    }
}
