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
    }
}
