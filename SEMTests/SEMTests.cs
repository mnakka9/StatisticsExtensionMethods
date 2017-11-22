using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsExtensionMethods;
using System.Collections.Generic;
using System.Linq;

namespace SEMTests
{
    [TestClass]
    public class SEMTests
    {
        [TestMethod]
        public void MedianTestNumbers()
        {
            IEnumerable<int> values = new List<int>() { 1, 2, 3, 4, 5, 6 };
            double actual = values.Median(i => Convert.ToDouble(i));
            double expected = 3.5d;
            Assert.AreEqual(expected, actual, $"Expected {expected} & Actual {actual}");
        }

        [TestMethod]
        public void MedianTestClass()
        {
            
            var employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="M",Age=1},
                new Employee(){Id=1,Name="M",Age=2},
                new Employee(){Id=1,Name="M",Age=3},
                new Employee(){Id=1,Name="M",Age=4},
                new Employee(){Id=1,Name="M",Age=5},
                new Employee(){Id=1,Name="M",Age=6}
            };
            double actual = employees.Median(i => Convert.ToDouble(i.Age));
            double expected = 3.5d;
            Assert.AreEqual(expected, actual, $"Expected {expected} & Actual {actual}");
        }


        [TestMethod]
        public void MedianTestStruct()
        {
            var employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="M",Age=1},
                new Employee(){Id=1,Name="M",Age=2},
                new Employee(){Id=1,Name="M",Age=3},
                new Employee(){Id=1,Name="M",Age=4},
                new Employee(){Id=1,Name="M",Age=5},
                new Employee(){Id=1,Name="M",Age=6}
            };
            double actual = employees.Median(i => Convert.ToDouble(i.Age));
            double expected = 3.5d;
            Assert.AreEqual(expected, actual, $"Expected {expected} & Actual {actual}");
        }

        [TestMethod]
        public void SDTestNumbers()
        {
            IEnumerable<int> values = new List<int>() { 1, 2, 3, 4, 5, 6 };
            string actual = values.StandardDeviation(i => Convert.ToDouble(i)).ToString("F");
            string expected = (1.71).ToString("F");
            Assert.AreEqual(expected, actual, $"Expected {expected} & Actual {actual}");
        }

        [TestMethod]
        public void SDTestClass()
        {
            var employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="M",Age=1},
                new Employee(){Id=1,Name="M",Age=2},
                new Employee(){Id=1,Name="M",Age=3},
                new Employee(){Id=1,Name="M",Age=4},
                new Employee(){Id=1,Name="M",Age=5},
                new Employee(){Id=1,Name="M",Age=6}
            };
            string actual = employees.StandardDeviation(i => Convert.ToDouble(i.Age)).ToString("F");
            string expected = (1.71).ToString("F");
            Assert.AreEqual(expected, actual, $"Expected {expected} & Actual {actual}");
        }


        [TestMethod]
        public void SDTestStruct()
        {
            var employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="M",Age=1},
                new Employee(){Id=1,Name="M",Age=2},
                new Employee(){Id=1,Name="M",Age=3},
                new Employee(){Id=1,Name="M",Age=4},
                new Employee(){Id=1,Name="M",Age=5},
                new Employee(){Id=1,Name="M",Age=6}
            };
            string actual = employees.StandardDeviation(i => Convert.ToDouble(i.Age)).ToString("F");
            string expected = (1.71).ToString("F");
            Assert.AreEqual(expected, actual, $"Expected {expected} & Actual {actual}");
        }


        [TestMethod]
        public void VarianceTestNumbers()
        {
            IEnumerable<int> values = new List<int>() { 1, 2, 3, 4, 5, 6 };
            string actual = values.Variance(i => Convert.ToDouble(i)).ToString("F");
            string expected = (2.92).ToString("F");
            Assert.AreEqual(expected, actual, $"Expected {expected} & Actual {actual}");
        }

        [TestMethod]
        public void VarianceTestClass()
        {
            var employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="M",Age=1},
                new Employee(){Id=1,Name="M",Age=2},
                new Employee(){Id=1,Name="M",Age=3},
                new Employee(){Id=1,Name="M",Age=4},
                new Employee(){Id=1,Name="M",Age=5},
                new Employee(){Id=1,Name="M",Age=6}
            };
            string actual = employees.Variance(i => Convert.ToDouble(i.Age)).ToString("F");
            string expected = (2.92).ToString("F");
            Assert.AreEqual(expected, actual, $"Expected {expected} & Actual {actual}");
        }


        [TestMethod]
        public void VarianceTestStruct()
        {
            var employees = new List<Employee>()
            {
                new Employee(){Id=1,Name="M",Age=1},
                new Employee(){Id=1,Name="M",Age=2},
                new Employee(){Id=1,Name="M",Age=3},
                new Employee(){Id=1,Name="M",Age=4},
                new Employee(){Id=1,Name="M",Age=5},
                new Employee(){Id=1,Name="M",Age=6}
            };
            string actual = employees.Variance(i => Convert.ToDouble(i.Age)).ToString("F");
            string expected = (2.92).ToString("F");
            Assert.AreEqual(expected, actual, $"Expected {expected} & Actual {actual}");
        }


    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

    }

    public struct EmployeeStruct
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

    }
}
