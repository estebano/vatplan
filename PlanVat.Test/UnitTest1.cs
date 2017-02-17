using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PlanVat.Managers;

namespace PlanVat.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<ICalculations> mock = new Mock<ICalculations>();
            mock.Setup(m => m.Calculate(
                    It.IsAny<double>(),
                    It.IsAny<double>()))
                .Returns<double, double>((a, b) => a * b);

            DoublesManager mgr = new DoublesManager(mock.Object);
            var result = mgr.Operate(2, 3);
            Assert.AreEqual(result, 2 * 3); 
        }
    }
}
