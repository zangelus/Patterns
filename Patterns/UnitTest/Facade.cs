using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facade;

namespace UnitTest
{
    /// <summary>
    /// Summary description for Facade
    /// </summary>
    [TestClass]
    public class FacadeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client = new FacadeMain();
            Assert.AreEqual(FacadeMain.msg1+FacadeMain.msg2+FacadeMain.msg3,client.MethodA());
            Assert.AreEqual(FacadeMain.msg3 + FacadeMain.msg4, client.MethodB());
        }
    }
}
