using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factory.ObjectFactory;
using Factory.API;
using System.Collections.Generic;
using System.Linq;


namespace UnitTest
{
    [TestClass]
    public class Factory
    {
        /// <summary>
        /// Client wants to create colors
        /// </summary>
        [TestMethod]
        public void FactoryMethod()
        {
            var factory = new ColorFactory();
            var colors = new List<IColor>();

            for(int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                {
                    colors.Add(factory.Create(ColorType.Blue));
                }
                else
                {
                    colors.Add(factory.Create(ColorType.Red));
                }
            }

            Assert.AreEqual(
                colors.Count(color => color.ColorName.Equals("Red")),
                colors.Count(color => color.ColorName.Equals("Blue"))
                );
        }
    }
}
