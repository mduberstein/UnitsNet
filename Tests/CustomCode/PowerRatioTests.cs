﻿// Copyright © 2007 by Initial Force AS.  All rights reserved.
// https://github.com/InitialForce/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.


using System;
using NUnit.Framework;

namespace UnitsNet.Tests.CustomCode
{
    public class PowerRatioTests : PowerRatioTestsBase
    {
        protected override double DecibelMilliwattsInOneDecibelWatt { get { return 31; } }

        protected override double DecibelWattsInOneDecibelWatt { get { return 1; } }

        protected override void AssertLogarithmicAddition()
        {
            PowerRatio v = PowerRatio.FromDecibelWatts(40);
            Assert.AreEqual(43.0102999566, (v + v).DecibelWatts, DecibelWattsTolerance);
        }

        protected override void AssertLogarithmicSubtraction()
        {
            PowerRatio v = PowerRatio.FromDecibelWatts(40);
            Assert.AreEqual(49.5424250944, (PowerRatio.FromDecibelWatts(50) - v).DecibelWatts, DecibelWattsTolerance);
        }
        
        #region From Power Tests

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        public void InvalidPower_ExpectArgumentOutOfRangeException(double power)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => PowerRatio.FromPower(Power.FromWatts(power)));
        }

        [TestCase(1, Result = 0)]
        [TestCase(10, Result = 10)]
        [TestCase(100, Result = 20)]
        public double ExpectPowerConvertedCorrectly(double power)
        {
            var p = Power.FromWatts(power);

            return PowerRatio.FromPower(p).DecibelWatts;
        }

        #endregion

        #region To Power Tests

        [TestCase(-20, Result = 0.01)]
        [TestCase(-10, Result = 0.1)]
        [TestCase(0,   Result = 1)]
        [TestCase(10,  Result = 10)]
        [TestCase(20,  Result = 100)]
        public double ExpectPowerRatioConvertedCorrectly(double powerRatio)
        {
            var pr = PowerRatio.FromDecibelWatts(powerRatio);

            return PowerRatio.ToPower(pr).Watts;
        }

        #endregion
    }
}