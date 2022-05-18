using NUnit.Framework;
using FluentAssertions;
using Calculator.Library;
using System;
using System.Collections.Generic;

namespace Calculator.Test
{
    [TestFixture]
    public class RechenopertionenTests : TestStacks
    {

        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(-8, 1, -8)]
        public void Divison_ShouldWork(double x, double y, double expected)
        {
            Rechenoperationen.Division(x, y);
            Assert.AreEqual(expected, Rechenoperationen.Division(x, y));
        }

        [Test]
        [TestCase(4, 0, 4)]
        public void Divison_ShouldNotWork(double x, double y, double expected)
        {
            Rechenoperationen.Division(x, y);
            Assert.AreEqual(expected, Rechenoperationen.Division(x, y));
        }

        [Test]
        [TestCase(4, 6)]
        [TestCase(1, 3)]
        [TestCase(2, 5)]
        public void SummeXElemente_ShouldWork(int x, double expected)
        {
            double actual = Rechenoperationen.SummeXElemente(x, CreateSimpleStack());

            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(10, 10)]
        [TestCase(5, 5)]
        public void SummeXElemente_ShouldNotWork(int x, double expected)
        {
            double actual = Rechenoperationen.SummeXElemente(x, CreateSimpleStack());
            Assert.AreEqual(expected, actual); 
        }

        [Test]
        [TestCase(2, 2.5)]
        [TestCase(3, 2)]
        [TestCase(4, 1.5)]
        public void ArithmetischesMittel_ShouldWork(int x, double expected)
        {
            double actual = Rechenoperationen.ArithmetischesMittel(x, CreateSimpleStack());
            Assert.AreEqual(expected, actual);
        }
        [Test]
        [TestCase(10, 10)]
        [TestCase(5, 5)]
        public void ArithmetischesMittel_ShouldNotWork(int x, double expected)
        {
            double actual = Rechenoperationen.ArithmetischesMittel(x, CreateSimpleStack());
            Assert.AreEqual(expected, actual);
        }


        [Test]
        [TestCase(-1, -1)]
        [TestCase(-8, -8)]
        public void QuadratWurzel_ShouldNotWork(double x, double expected)
        {
            double actual = Rechenoperationen.Quadratwurzel(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
