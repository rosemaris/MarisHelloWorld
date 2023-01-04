using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class CUmulativeArraySumUnitTest
    {
        [Test]
        public void GenericTests()
        {
            var cUmulativeArraySum = new CUmulativeArraySum();
            double[] haystack_1 = new double[] { };
            double[] haystack_2 = new double[] { 1 };
            double[] haystack_3 = new double[] { 1, 2, 3 };
            double[] haystack_4 = new double[] { -1, -2, -3 };
            double[] haystack_5 = new double[] { 1, -2, 3 };
            double[] haystack_6 = new double[] { 3, 3, -2, 408, 3, 3, 0, 66, 2, -2, 2, 3, 4, 2, -47, 3, 3, 2 };


            Assert.AreEqual(new double[] { }, cUmulativeArraySum.Get(haystack_1));
            Assert.AreEqual(new double[] { 1 }, cUmulativeArraySum.Get(haystack_2));
            Assert.AreEqual(new double[] { 1, 3, 6 }, cUmulativeArraySum.Get(haystack_3));
            Assert.AreEqual(new double[] { -1, -3, -6 }, cUmulativeArraySum.Get(haystack_4));
            Assert.AreEqual(new double[] { 1, -1, 2 }, cUmulativeArraySum.Get(haystack_5));
            Assert.AreEqual(new double[] { 3, 6, 4, 412, 415, 418, 418, 484, 486, 484, 486, 489, 493, 495, 448, 451, 454, 456 }, cUmulativeArraySum.Get(haystack_6));
        }
    }
}
