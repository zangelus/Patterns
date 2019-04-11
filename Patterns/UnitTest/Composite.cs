using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Composite;

namespace UnitTest
{
    /// <summary>
    /// Summary description for Composite
    /// </summary>
    [TestClass]
    public class Composite:TestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new Client();
            Console.WriteLine("Composite 1");
            Console.WriteLine(FormatXml(test.Cmp1.GetHtml()));

            Console.WriteLine("Composite 2");
            Console.WriteLine(FormatXml(test.Cmp2.GetHtml()));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var test = new Client();
            Console.WriteLine("Document");
            Console.WriteLine(FormatXml(test.Document.GetHtml()));
        }
    }
}
