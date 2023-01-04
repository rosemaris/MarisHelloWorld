using Computations.Challenges.Level1_VeryEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests
{
    [TestFixture]
    internal class AddingTwoNumbersUnitTest
    {
        [Test]
        [TestCase(2, 3, ExpectedResult = 5)]
        [TestCase(-3, -6, ExpectedResult = -9)]
        [TestCase(7, 3, ExpectedResult = 10)]
        public static int Sum(int a, int b)
        {
            var sumOfTwoNumbers = new AddingTwoNumbers();
            return sumOfTwoNumbers.Get(a, b);
        }
    }
}
