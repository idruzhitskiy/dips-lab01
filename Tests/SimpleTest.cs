using Lab01.Controllers;
using Lab01.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class SimpleTest
    {
        [TestMethod]
        public void TestIncrementUnit()
        {
            var simpleLogicMock = new Mock<ISimpleLogic>();
            simpleLogicMock.Setup(logic => logic.Inc(It.IsAny<int>())).Returns<int>(i => ++i);
            var controller = new ValuesController(simpleLogicMock.Object);
            Assert.AreEqual(controller.Increment(5), 6);
        }

        [TestMethod]
        public void TestIncrementIntegration()
        {
            var controller = new ValuesController(new SimpleLogic());
            Assert.AreEqual(controller.Increment(5), 6);
        }

        [TestMethod]
        public void TestSumUnit()
        {
            var simpleLogicMock = new Mock<ISimpleLogic>();
            simpleLogicMock.Setup(logic => logic.Sum(It.IsAny<int>(), It.IsAny<int>()))
                .Returns<int, int>((a, b) => a + b);
            var controller = new ValuesController(simpleLogicMock.Object);
            Assert.AreEqual(controller.Sum(1, 1), 2);
        }

        [TestMethod]
        public void TestSumIntegration()
        {
            var controller = new ValuesController(new SimpleLogic());
            Assert.AreEqual(controller.Sum(1, 1), 2);
        }
    }
}
