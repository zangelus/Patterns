using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;

namespace UnitTest
{
    /// <summary>
    /// Summary description for Singleton
    /// </summary>
    [TestClass]
    public class Singleton
    {
        [TestMethod]
        public void TestMethod1()
        {
            var _cars = new List<Car>()
            {
                new Car{Maker="Toyota",Year=2008},
                new Car{Maker="Toyota",Year=2009},
                new Car{Maker="Toyota",Year=2010},
            };

            var catalog = CarCatalog.GetCarCatalog();

            var result = catalog.GetNext

            foreach(var car in catalog.GetNext)
            {
                var c = car;
            }

        }
    }
}
