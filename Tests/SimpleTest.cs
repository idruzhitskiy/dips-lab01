using Lab01.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SimpleTest
    {
        [TestMethod]
        public void TestIncrement()
        {
            var controller = new ValuesController();
            Assert.AreEqual(controller.Increment(5), "6");
        }

        [TestMethod]
        public void TestSum()
        {
            var controller = new ValuesController();
            Assert.AreEqual(controller.Sum(1, 1), "2");
        }
    }
}
