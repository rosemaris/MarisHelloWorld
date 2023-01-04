using Computations.Challenges.Level1_VeryEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    [TestFixture]
    internal class RemainderOfTwoNumbersUnitTest
    {
        [Test]
        [TestCase(7, 2, ExpectedResult = 1)]
        [TestCase(3, 4, ExpectedResult = 3)]
        [TestCase(-9, 45, ExpectedResult = -9)]
        [TestCase(5, 5, ExpectedResult = 0)]
        public static int Remainder(int x, int y)
        {
            var remainderOfTwoNumbers = new RemainderOfTwoNumbers();
            return remainderOfTwoNumbers.Get(x, y);
        }
    }
}
