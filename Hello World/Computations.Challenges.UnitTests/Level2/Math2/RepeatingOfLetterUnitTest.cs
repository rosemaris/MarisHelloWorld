using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class RepeatingOfLetterUnitTest
    {
        [Test]
        [TestCase(3, ExpectedResult = "Burrrp")]
        [TestCase(5, ExpectedResult = "Burrrrrp")]
        [TestCase(9, ExpectedResult = "Burrrrrrrrrp")]
        [TestCase(10, ExpectedResult = "Burrrrrrrrrrp")]
        [TestCase(13, ExpectedResult = "Burrrrrrrrrrrrrp")]
        [TestCase(18, ExpectedResult = "Burrrrrrrrrrrrrrrrrrp")]
        [TestCase(1, ExpectedResult = "Burp")]
        public static string Get_ShouldReturnWithNumberofRepeatedChar_WhenPassingANumber(int a)
        {
            var repeatingOfLetter = new RepeatingOfLetter();
            return repeatingOfLetter.Get(a);
        }
    }
}
