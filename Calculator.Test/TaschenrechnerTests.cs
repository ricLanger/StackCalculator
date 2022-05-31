using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Library;
using Calculator.Library.RechenOperationen;
using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    internal class TaschenrechnerTests : CreateStacks
    {
        
        [Test]
        public void TestAdditionCalculation()
        {
            IOperator op = new Addition();
            double expected = 5;
            double actual = op.Calculate(CreateSimpleStack());
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSubtraktionCalculation()
        {
            IOperator op = new Subtraktion();
            double expected = -1;
            double actual = op.Calculate(CreateSimpleStack());
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMultiplikationCalculation()
        {
            IOperator op = new Multiplikation();
            double expected = 6;
            double actual = op.Calculate(CreateSimpleStack());
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestDivisionCalculation()
        {
            IOperator op = new Divison();
            double expected = 0.6667;
            double actual = op.Calculate(CreateSimpleStack());
            Assert.AreEqual(expected, actual);
        }
    }
}
