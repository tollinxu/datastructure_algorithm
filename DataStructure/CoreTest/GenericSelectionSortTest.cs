using SelectionSort;
using System;
using Xunit;

namespace CoreTest
{
    //[TestFixture]
    public class GenericSelectionSortTest
    {
        [Fact]
        public void Test1()
        {
            var students = new Student[] {
                new Student()
                {
                    Name="Jack",
                    Score = 90
                },
                new Student()
                {
                    Name = "Kevin",
                    Score = 91,
                },
                new Student()
                {
                    Name = "Tony",
                    Score = 82
                }
            };

            var sortedStudents = GenericSelectionSort.SelectionSort(students);
            Assert.Equal("Tony", sortedStudents[0].Name);
        }

        [Fact]
        public void TestSortWithHelper()
        {
            var length = 10000;
            var array = SortHelper.GetArray(length, 0, length);
            var sortArray = GenericSelectionSort.SelectionSort(array);
            SortHelper.PrintArry(array);
        }
    }
}
