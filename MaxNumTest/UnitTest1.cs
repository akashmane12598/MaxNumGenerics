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
            int expected = 30;
            int actual = MaxNum.Max(30,20,10);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 1.2
        /// </summary>
        [TestMethod]
        public void TestForMaxNumInt_TC1_2()
        {
            int expected = 30;
            int actual = MaxNum.Max(20, 30, 10);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 1.3
        /// </summary>
        [TestMethod]
        public void TestForMaxNumInt_TC1_3()
        {
            int expected = 30;
            int actual = MaxNum.Max(10, 20, 30);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 2.1
        /// </summary>
        [TestMethod]
        public void TestForMaxNumFloat_TC2_1()
        {
            double expected = 30.5;
            double actual = MaxNum.Max(30.5,20.5,10.5);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 2.2
        /// </summary>
        [TestMethod]
        public void TestForMaxNumFloat_TC2_2()
        {
            double expected = 30.5;
            double actual = MaxNum.Max(20.5, 30.5, 10.5);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 2.3
        /// </summary>
        [TestMethod]
        public void TestForMaxNumFloat_TC2_3()
        {
            double expected = 30.5;
            double actual = MaxNum.Max(10.5, 20.5, 30.5);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 3.1
        /// </summary>
        [TestMethod]
        public void TestForMaxString_TC3_1()
        {
            string expected = "Peach";
            string actual = MaxNum.Max("Peach","Apple","Banana");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 3.2
        /// </summary>
        [TestMethod]
        public void TestForMaxString_TC3_2()
        {
            string expected = "Peach";
            string actual = MaxNum.Max("Apple", "Peach", "Banana");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TC 3.3
        /// </summary>
        [TestMethod]
        public void TestForMaxString_TC3_3()
        {
            string expected = "Peach";
            string actual = MaxNum.Max("Apple", "Banana", "Peach");
            Assert.AreEqual(expected, actual);
        }

    }
}
