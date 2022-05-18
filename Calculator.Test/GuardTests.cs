using NUnit.Framework;
using FluentAssertions;
using Calculator.Library;
using System;
using System.Collections.Generic;

namespace Calculator.Test
{
    [TestFixture]
    public class GuardTests : TestStacks
    {
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
        [Test]
        public void StackRangeGuard_ShouldBeFalseOneItemStack()
        {
            bool actual = Guards.StackRangeGuard("9", CreateOneItemStack());
            Assert.False(actual);
        }

        [Test]
        [TestCase("")]
        [TestCase("o")]
        [TestCase("tz")]
        [TestCase(" ")]
        [TestCase("++")]
        public void OpGuard_ShouldBeFalse(string input)
        {
            bool actual = Guards.OpGuard(input, CreateSimpleStack());

            Assert.False(actual);
        }
        [Test]
        [TestCase("+")]
        [TestCase("3")]
        public void OpGuard_ShouldBeFalseEmptyStack(string input)
        {
            bool actual = Guards.OpGuard(input, CreateEmptyStack());
            Assert.False(actual);
        }
        [Test]
        [TestCase("+")]
        [TestCase("-")]
        [TestCase("sum")]
        [TestCase("sqrt")]
        public void OpGuard_ShouldBeTrue(string input)
        {
            Guards.OpGuard(input, CreateSimpleStack());
        }
    }
}
