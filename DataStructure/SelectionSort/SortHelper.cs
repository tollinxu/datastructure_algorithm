using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
    public class SortHelper
    {
        public static int[] GetArray(int count, int minValue, int maxValue)
        {
            System.Diagnostics.Debug.Assert(minValue < maxValue, "minValue should smaller than maxValue");
            var array = new int[count];
            var random = new Random();
            while(count > 0)
            {
                count--;
                array[count] = random.Next(minValue, maxValue);
            }
            return array;
        }

        public static void PrintArry(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine("item=" + item);
            }
        }

        public static bool SortCheck<T>(T[] array) where T: IComparable
        {            
            var privous = array[0];
            foreach (var item in array)
            {
                if(privous.CompareTo(item) > 0)
                {
                    return false;
                }               
            }
            return true;
        }

        public static T[] DeepCopy<T>(int length, T[] array)
        {
            var newArry = new T[length];
            for (int i = 0; i < length; i++)
            {
                newArry[i] = array[i];
            }
            return newArry;
        }

        public static void SortExecure<T>(string methodName, SortDelegate<T> method, int count, T[] array) where T : IComparable
        {
            var begin = DateTime.Now;
           var sortArray =  method(array);
            var end = DateTime.Now;
            var duration = (end - begin).TotalMilliseconds;

            if (SortCheck(sortArray))
            {
                Console.WriteLine("Sort correctly");
            }
            else
            {
                Console.WriteLine("Sort incorrectly");
            }

            Console.WriteLine(methodName + "execute for " + duration + " millisecond");
        }
    }

    public delegate T[] SortDelegate<T>(T[] array);
}
