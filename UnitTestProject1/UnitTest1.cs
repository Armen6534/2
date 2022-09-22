using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual(Convert.ToString(class1.MassaGruza(5, 4, 6, 2)), Convert.ToString(240));
        }
    }
}
