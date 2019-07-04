using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Original();

            //SortWithHelper();
            var length = 10000;
            var array = SortHelper.GetArray(length, 0, length);
            var array2 = SortHelper.DeepCopy(length, array);
            var array3 = SortHelper.DeepCopy(length, array);
            var array4 = SortHelper.DeepCopy(length, array);

            SortWithMeasure("GenericSelectionSort.SelectionSort", length, array, GenericSelectionSort.SelectionSort);

            SortWithMeasure("InsertSelection.Sort", length, array2, InsertSelection.Sort);

            SortWithMeasure("InsertSelection.OptimiseSort", length, array3, InsertSelection.OptimiseSort);

            SortWithMeasure("MergeSort.Sort", length, array4, MergeSort<int>.Sort);


            Console.ReadKey();
        }

        private static void SortWithMeasure<T>(string name, int length, T[] array, SortDelegate<T> method) where T: IComparable
        {            
            SortHelper.SortExecure(name, method, length, array);
        }

        private static void Original()
        {
            int[] array = new int[] { 7, 8, 9, 6, 5, 4, 1, 2, 3 };

            array = SelectionSort(array);

            foreach (var item in array)
            {
                Console.Write(item + "\t");
            }
        }

        private static void SortWithHelper()
        {
            var length = 10000;
            var array = SortHelper.GetArray(length, 0, length);
            var sortArray = GenericSelectionSort.SelectionSort(array);
            SortHelper.PrintArry(array);
        }

        public static int[] SelectionSort(int[] array)
        {
            int lenght = array.Length;
            int minIndex = 0;
            for (int i = 0; i < lenght; i++)
            {
                minIndex = i;
                for (int j = i+1; j < lenght; j++)
                {
                    if(array[minIndex] > array[j])
                    {
                        int temp = array[minIndex];
                        array[minIndex] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}