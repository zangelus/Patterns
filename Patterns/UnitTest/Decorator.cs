using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decorator;

namespace UnitTest
{
    /// <summary>
    /// Summary description for Decorator
    /// </summary>
    [TestClass]
    public class Decorator:TestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            var clientOrder = new Client();
            Assert.AreEqual(5.0M, clientOrder.Order1);
            Assert.AreEqual(3.8M, clientOrder.Order2);
        }
    }
}
