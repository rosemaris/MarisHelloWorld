using Computations.Challenges.Level1_VeryEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    [TestFixture]
    internal class IncrementingBy1UnitTest
    {
        [Test]
        [TestCase(2, ExpectedResult = 3)]
        [TestCase(-9, ExpectedResult = -8)]
        [TestCase(0, ExpectedResult = 1)]
        [TestCase(100, ExpectedResult = 101)]
        [TestCase(999, ExpectedResult = 1000)]
        [TestCase(73, ExpectedResult = 74)]
        public static int Addition(int num)
        {
            var incrementingBy1 = new IncrementingBy1();
            return incrementingBy1.Increase(num);
        }
    }
}
