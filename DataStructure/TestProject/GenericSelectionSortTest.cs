using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelectionSort;

namespace TestProject
{
    [TestClass]
    public class GenericSelectionSortTest
    {
        [TestMethod]
        public void TestMethod1()
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
            Assert.AreEqual("Tony", sortedStudents[0].Name);
        }
    }
}
