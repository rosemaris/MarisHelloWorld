using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class EliminatingOddNumbersWithinAnArrayUnitTest
    {
        [Test]
        public void Get_ShouldReturnToEvenNUmbers_WheanPassingAnArray()
        {
            int[] haystack_1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] haystack_2 = new int[] { 43, 65, 23, 89, 53, 9, 6 };
            int[] haystack_3 = new int[] { 718, 991, 449, 644, 380, 440 };
            int[] haystack_4 = new int[] { 148, 6, 16, 85 };
            int[] haystack_5 = new int[] { 9, 49, 23 };
            int[] haystack_6 = new int[] { 34, 43, 32, 49, 40 };
            int[] haystack_7 = new int[] { 1232, 1990, 1284, 1391, 1958 };
            int[] haystack_8 = new int[] { 2766, 2651, 2373, 2916, 2397, 2539 };
            int[] haystack_9 = new int[] { 53, 65, 52, 62, 59 };
            int[] haystack_10 = new int[] { 393, 156, 14, 166, 129, 246 };

            var eliminatingOddNumbersWithinAnArray = new EliminatingOddNumbersWithinAnArray();
            Assert.AreEqual(new int[] { 2, 4, 6, 8 }, eliminatingOddNumbersWithinAnArray.Get(haystack_1));
            Assert.AreEqual(new int[] { 6 }, eliminatingOddNumbersWithinAnArray.Get(haystack_2));
            Assert.AreEqual(new int[] { 718, 644, 380, 440 }, eliminatingOddNumbersWithinAnArray.Get(haystack_3));
            Assert.AreEqual(new int[] { 148, 6, 16 }, eliminatingOddNumbersWithinAnArray.Get(haystack_4));
            Assert.AreEqual(new int[] { }, eliminatingOddNumbersWithinAnArray.Get(haystack_5));
            Assert.AreEqual(new int[] { 34, 32, 40 }, eliminatingOddNumbersWithinAnArray.Get(haystack_6));
            Assert.AreEqual(new int[] { 1232, 1990, 1284, 1958 }, eliminatingOddNumbersWithinAnArray.Get(haystack_7));
            Assert.AreEqual(new int[] { 2766, 2916 }, eliminatingOddNumbersWithinAnArray.Get(haystack_8));
            Assert.AreEqual(new int[] { 52, 62 }, eliminatingOddNumbersWithinAnArray.Get(haystack_9));
            Assert.AreEqual(new int[] { 156, 14, 166, 246 }, eliminatingOddNumbersWithinAnArray.Get(haystack_10));
        }
    }
}
