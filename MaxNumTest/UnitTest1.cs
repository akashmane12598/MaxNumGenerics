using MaxNumGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaxNumTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 1.1
        /// </summary>
        [TestMethod]
        public void TestForMaxNumInt_TC1_1()
        {
            int expected = 50;
            int[] arr = { 10, 20, 30, 40, 50 };
            MaxNum<int>.Max(arr);
            int actual = MaxNum<int>.max;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 1.2
        /// </summary>
        [TestMethod]
        public void TestForMaxNumInt_TC1_2()
        {
            int expected = 50;
            int[] arr = { 10, 20, 30, 40, 50 };
            MaxNum<int>.Max(arr);
            int actual = MaxNum<int>.max;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 1.3
        /// </summary>
        [TestMethod]
        public void TestForMaxNumInt_TC1_3()
        {
            int expected = 50;
            int[] arr = { 10, 20, 30, 40, 50 };
            MaxNum<int>.Max(arr);
            int actual = MaxNum<int>.max;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 2.1
        /// </summary>
        [TestMethod]
        public void TestForMaxNumFloat_TC2_1()
        {
            double expected = 50.5;
            double[] arr2 = { 10.5, 20.5, 30.5, 40.5, 50.5 };
            MaxNum<double>.Max(arr2);
            double actual = MaxNum<double>.max;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 2.2
        /// </summary>
        [TestMethod]
        public void TestForMaxNumFloat_TC2_2()
        {
            double expected = 50.5;
            double[] arr2 = { 10.5, 20.5, 30.5, 40.5, 50.5 };
            MaxNum<double>.Max(arr2);
            double actual = MaxNum<double>.max;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 2.3
        /// </summary>
        [TestMethod]
        public void TestForMaxNumFloat_TC2_3()
        {
            double expected = 50.5;
            double[] arr2 = { 10.5, 20.5, 30.5, 40.5, 50.5 };
            MaxNum<double>.Max(arr2);
            double actual = MaxNum<double>.max;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 3.1
        /// </summary>
        [TestMethod]
        public void TestForMaxString_TC3_1()
        {
            string expected = "Virat";
            string[] arr3 = { "Rohit", "Virat", "Rahul", "Shami", "Bumrah" };
            MaxNum<string>.Max(arr3);
            string actual = MaxNum<string>.max;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 3.2
        /// </summary>
        [TestMethod]
        public void TestForMaxString_TC3_2()
        {
            string expected = "Virat";
            string[] arr3 = { "Rohit", "Virat", "Rahul", "Shami", "Bumrah" };
            MaxNum<string>.Max(arr3);
            string actual = MaxNum<string>.max;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 3.3
        /// </summary>
        [TestMethod]
        public void TestForMaxString_TC3_3()
        {
            string expected = "Virat";
            string[] arr3 = { "Rohit", "Virat", "Rahul", "Shami", "Bumrah" };
            MaxNum<string>.Max(arr3);
            string actual = MaxNum<string>.max;
            Assert.AreEqual(expected, actual);
        }

    }
}
