using NUnit.Framework;
using FluentAssertions;
using Calculator.Library;
using System;
using System.Collections.Generic;

namespace Calculator.Test
{
    [TestFixture]
    public class TaschenrechnerTests : TestStacks
    {
        [Test]
        [TestCase("1.98235", 1.9824)]
        [TestCase("-5.86431", -5.8643)]
        [TestCase("0.00004", 0)]
        [TestCase("0.00009", 0.0001)]
        public void PushAndRound_ShouldWork(double input, double expcted)
        {
            Taschenrechner.PushAndRound(input, CreateSimpleStack());
            Taschenrechner.PushAndRound(input, CreateEmptyStack());
        }

        [Test]
        [TestCase("+", 5)]
        [TestCase("-", 1)]
        [TestCase("*", 6)]
        [TestCase("/", 1.5)]
        [TestCase("^2", 9)]
        [TestCase("sqrt", 1.7321)]
        [TestCase("^", 9)]
        [TestCase("sum", 3)]
        [TestCase("avg", 1)]
        public void RechenoperationEingeben_ShouldWork(string input, double expected)
        {
            double actual = Math.Round(Taschenrechner.RechenoperationDurchführen(input, CreateSimpleStack()), 4);

            Assert.AreEqual(expected, actual);
        }
    }
}
