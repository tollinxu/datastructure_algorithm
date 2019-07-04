using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
    public class InsertSelection
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="n"></param>
        /// <param name="arry"></param>
        /// <returns></returns>
        public static T[] Sort<T>(T[] arry) where T : IComparable
        {
            if(arry == null)
            {
                return null;
            }
            var n = arry.Length;
            for (int i = 1; i < n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    var current = arry[j];
                    var pre = arry[j-1];
                    if(pre.CompareTo(current) < 0)
                    {
                        break;
                    }
                    var temp = current;
                    arry[j] = pre;
                    arry[j - 1] = temp;
                }
            }
            return arry;
        }


        public static T[] OptimiseSort<T>(T[] arry) where T : IComparable
        {
            if (arry == null)
            {
                return null;
            }
            var n = arry.Length;
            for (int i = 1; i < n; i++)
            {
                T current = arry[i];
                int j;
                for (j = i; j > 0; j--)
                {
                    var pre = arry[j-1];
                    if (pre.CompareTo(current) < 0)
                    {
                        break;
                    }
                    arry[j] = pre;
                }
                arry[j] = current;
            }
            return arry;
        }
    }
}
