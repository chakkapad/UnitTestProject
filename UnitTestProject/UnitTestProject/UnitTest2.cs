using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibraryUnitTestProject;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            AssigamentClass assigamentClass = new AssigamentClass();
            int input = 1020;

            string result = assigamentClass.greadCalculate(input);
            Assert.AreEqual("A", result);

        }

        [TestMethod]
        public void TestMethod2()
        {
            AssigamentClass assigamentClass = new AssigamentClass();
            double result = assigamentClass.getDistance(3, 2, 7, 8);
            Assert.AreEqual(7.21, result);
            result = assigamentClass.getDistance(-3, 2, 7, -8);
            Assert.AreEqual(14.14, result);
            result = assigamentClass.getDistance(-3, -2, -7, -8);
            Assert.AreEqual(7.21, result);
            result = assigamentClass.getDistance(3, -2, -7, 8);
            Assert.AreEqual(14.14, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            AssigamentClass assigamentClass = new AssigamentClass();
            int result = assigamentClass.getFactorial(8);
            Assert.AreEqual(40320, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            AssigamentClass assigamentClass = new AssigamentClass();
            string Password = "11111111D";
            bool password = assigamentClass.checkPassword(Password);
            Assert.AreEqual(true, password);
                
        }
    }
}
