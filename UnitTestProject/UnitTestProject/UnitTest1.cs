using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibraryUnitTestProject;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Add1()
        {
            MyMath myMath = new MyMath();
            int result = myMath.Add(1, 2);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMethod_Add2()
        {
            MyMath myMath = new MyMath();
            int result = myMath.Add(11, 22);
            Assert.AreEqual(33, result);
        }
    }
}
