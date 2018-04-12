using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestSum()
        {
            int a = 2;
            int b = 3;

            Assert.AreEqual(5, a + b);
        }

        [TestMethod]
        public void TestConcatenateNames()
        {
            Entity entity = new Entity();

            Assert.AreEqual("Hello World", entity.ConcatenateName("Hello", "World"));

        }
    }
}
