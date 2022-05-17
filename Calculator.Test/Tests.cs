using NUnit.Framework;
using FluentAssertions;
using Calculator.Library;
using System;
using System.Collections.Generic;

namespace Calculator.Test
{
    [TestFixture]
    public class Tests
    {
        //static Stack<double> stack = new Stack<double>();    
        private Stack<double> CreateSimpleStack()
        {
            Stack<double> stack = new ();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            return stack;
        }

        [Test]
        [TestCase(3)]
        [TestCase(-4)]
        public void TestDivisionGuardNotNull(double x)
        {
            Guards.DivisionGuard(x);
        }
        [Test]
        [TestCase(4, 6)]
        [TestCase(1, 3)]
        [TestCase(2, 5)]
        public void SummeOp_ShouldWork(int x, double expected)
        {

            double actual = Rechenoperationen.SummeXElemente(x, CreateSimpleStack());

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase("+")]
        [TestCase("-")]
        [TestCase("*")]
        [TestCase("/")]
        [TestCase("^2")]
        [TestCase("sqrt")]
        [TestCase("^")]
        [TestCase("sum")]
        [TestCase("avg")]
        public void OpGuard_ShouldWork(string input)
        {
            bool actual = Guards.OpGuard(input, CreateSimpleStack());

            Assert.True(actual);
        }

        [Test]
        [TestCase("+")]
        [TestCase("-")]
        [TestCase("*")]
        [TestCase("/")]
        [TestCase("^")]
        [TestCase("sum")]
        [TestCase("avg")]
        public void StackRangeGuard_ShouldBeTrue(string input)
        {
            bool actual = Guards.StackRangeGuard(input, CreateSimpleStack());

            Assert.True(actual);
        }
        [Test]
        [TestCase("^2")]
        [TestCase("sqrt")]
        public void StackRangeGuard_ShouldBeFalse(string input)
        {
            bool actual = Guards.StackRangeGuard(input, CreateSimpleStack());

            Assert.False(actual);
        }
    }
}