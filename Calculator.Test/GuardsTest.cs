using NUnit.Framework;
using FluentAssertions;
using Calculator.Library;
using System;

namespace Calculator.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestDivisionGuardEqualsNull()
        {
            Action action = () => Guards.DivisionGuard(0);
            action.Should().Throw<ArgumentOutOfRangeException>();
        }        
        [Test]
        [TestCase (3)]
        [TestCase (-4)]
        public void TestDivisionGuardNotNull(double x)
        {
            Guards.DivisionGuard(x);           
        }
    }
}