﻿// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
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

#if !WINDOWS_UWP
// Extension methods/overloads not supported in Universal Windows Platform (WinRT Components)
namespace UnitsNet.Extensions.NumberToSpecificEnergy
{
    public static class NumberToSpecificEnergyExtensions
    {
        #region CaloriePerGram

        /// <inheritdoc cref="SpecificEnergy.FromCaloriesPerGram(double)"/>
        public static SpecificEnergy CaloriesPerGram(this int value) => SpecificEnergy.FromCaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromCaloriesPerGram(double?)"/>
        public static SpecificEnergy? CaloriesPerGram(this int? value) => SpecificEnergy.FromCaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromCaloriesPerGram(double)"/>
        public static SpecificEnergy CaloriesPerGram(this long value) => SpecificEnergy.FromCaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromCaloriesPerGram(double?)"/>
        public static SpecificEnergy? CaloriesPerGram(this long? value) => SpecificEnergy.FromCaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromCaloriesPerGram(double)"/>
        public static SpecificEnergy CaloriesPerGram(this double value) => SpecificEnergy.FromCaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromCaloriesPerGram(double?)"/>
        public static SpecificEnergy? CaloriesPerGram(this double? value) => SpecificEnergy.FromCaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromCaloriesPerGram(double)"/>
        public static SpecificEnergy CaloriesPerGram(this float value) => SpecificEnergy.FromCaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromCaloriesPerGram(double?)"/>
        public static SpecificEnergy? CaloriesPerGram(this float? value) => SpecificEnergy.FromCaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromCaloriesPerGram(double)"/>
        public static SpecificEnergy CaloriesPerGram(this decimal value) => SpecificEnergy.FromCaloriesPerGram(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEnergy.FromCaloriesPerGram(double?)"/>
        public static SpecificEnergy? CaloriesPerGram(this decimal? value) => SpecificEnergy.FromCaloriesPerGram(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region JoulePerKilogram

        /// <inheritdoc cref="SpecificEnergy.FromJoulesPerKilogram(double)"/>
        public static SpecificEnergy JoulesPerKilogram(this int value) => SpecificEnergy.FromJoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromJoulesPerKilogram(double?)"/>
        public static SpecificEnergy? JoulesPerKilogram(this int? value) => SpecificEnergy.FromJoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromJoulesPerKilogram(double)"/>
        public static SpecificEnergy JoulesPerKilogram(this long value) => SpecificEnergy.FromJoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromJoulesPerKilogram(double?)"/>
        public static SpecificEnergy? JoulesPerKilogram(this long? value) => SpecificEnergy.FromJoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromJoulesPerKilogram(double)"/>
        public static SpecificEnergy JoulesPerKilogram(this double value) => SpecificEnergy.FromJoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromJoulesPerKilogram(double?)"/>
        public static SpecificEnergy? JoulesPerKilogram(this double? value) => SpecificEnergy.FromJoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromJoulesPerKilogram(double)"/>
        public static SpecificEnergy JoulesPerKilogram(this float value) => SpecificEnergy.FromJoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromJoulesPerKilogram(double?)"/>
        public static SpecificEnergy? JoulesPerKilogram(this float? value) => SpecificEnergy.FromJoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromJoulesPerKilogram(double)"/>
        public static SpecificEnergy JoulesPerKilogram(this decimal value) => SpecificEnergy.FromJoulesPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEnergy.FromJoulesPerKilogram(double?)"/>
        public static SpecificEnergy? JoulesPerKilogram(this decimal? value) => SpecificEnergy.FromJoulesPerKilogram(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilocaloriePerGram

        /// <inheritdoc cref="SpecificEnergy.FromKilocaloriesPerGram(double)"/>
        public static SpecificEnergy KilocaloriesPerGram(this int value) => SpecificEnergy.FromKilocaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilocaloriesPerGram(double?)"/>
        public static SpecificEnergy? KilocaloriesPerGram(this int? value) => SpecificEnergy.FromKilocaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilocaloriesPerGram(double)"/>
        public static SpecificEnergy KilocaloriesPerGram(this long value) => SpecificEnergy.FromKilocaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilocaloriesPerGram(double?)"/>
        public static SpecificEnergy? KilocaloriesPerGram(this long? value) => SpecificEnergy.FromKilocaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilocaloriesPerGram(double)"/>
        public static SpecificEnergy KilocaloriesPerGram(this double value) => SpecificEnergy.FromKilocaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilocaloriesPerGram(double?)"/>
        public static SpecificEnergy? KilocaloriesPerGram(this double? value) => SpecificEnergy.FromKilocaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilocaloriesPerGram(double)"/>
        public static SpecificEnergy KilocaloriesPerGram(this float value) => SpecificEnergy.FromKilocaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilocaloriesPerGram(double?)"/>
        public static SpecificEnergy? KilocaloriesPerGram(this float? value) => SpecificEnergy.FromKilocaloriesPerGram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilocaloriesPerGram(double)"/>
        public static SpecificEnergy KilocaloriesPerGram(this decimal value) => SpecificEnergy.FromKilocaloriesPerGram(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEnergy.FromKilocaloriesPerGram(double?)"/>
        public static SpecificEnergy? KilocaloriesPerGram(this decimal? value) => SpecificEnergy.FromKilocaloriesPerGram(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilojoulePerKilogram

        /// <inheritdoc cref="SpecificEnergy.FromKilojoulesPerKilogram(double)"/>
        public static SpecificEnergy KilojoulesPerKilogram(this int value) => SpecificEnergy.FromKilojoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilojoulesPerKilogram(double?)"/>
        public static SpecificEnergy? KilojoulesPerKilogram(this int? value) => SpecificEnergy.FromKilojoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilojoulesPerKilogram(double)"/>
        public static SpecificEnergy KilojoulesPerKilogram(this long value) => SpecificEnergy.FromKilojoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilojoulesPerKilogram(double?)"/>
        public static SpecificEnergy? KilojoulesPerKilogram(this long? value) => SpecificEnergy.FromKilojoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilojoulesPerKilogram(double)"/>
        public static SpecificEnergy KilojoulesPerKilogram(this double value) => SpecificEnergy.FromKilojoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilojoulesPerKilogram(double?)"/>
        public static SpecificEnergy? KilojoulesPerKilogram(this double? value) => SpecificEnergy.FromKilojoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilojoulesPerKilogram(double)"/>
        public static SpecificEnergy KilojoulesPerKilogram(this float value) => SpecificEnergy.FromKilojoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilojoulesPerKilogram(double?)"/>
        public static SpecificEnergy? KilojoulesPerKilogram(this float? value) => SpecificEnergy.FromKilojoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilojoulesPerKilogram(double)"/>
        public static SpecificEnergy KilojoulesPerKilogram(this decimal value) => SpecificEnergy.FromKilojoulesPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEnergy.FromKilojoulesPerKilogram(double?)"/>
        public static SpecificEnergy? KilojoulesPerKilogram(this decimal? value) => SpecificEnergy.FromKilojoulesPerKilogram(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilowattHourPerKilogram

        /// <inheritdoc cref="SpecificEnergy.FromKilowattHoursPerKilogram(double)"/>
        public static SpecificEnergy KilowattHoursPerKilogram(this int value) => SpecificEnergy.FromKilowattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilowattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? KilowattHoursPerKilogram(this int? value) => SpecificEnergy.FromKilowattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilowattHoursPerKilogram(double)"/>
        public static SpecificEnergy KilowattHoursPerKilogram(this long value) => SpecificEnergy.FromKilowattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilowattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? KilowattHoursPerKilogram(this long? value) => SpecificEnergy.FromKilowattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilowattHoursPerKilogram(double)"/>
        public static SpecificEnergy KilowattHoursPerKilogram(this double value) => SpecificEnergy.FromKilowattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilowattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? KilowattHoursPerKilogram(this double? value) => SpecificEnergy.FromKilowattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilowattHoursPerKilogram(double)"/>
        public static SpecificEnergy KilowattHoursPerKilogram(this float value) => SpecificEnergy.FromKilowattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilowattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? KilowattHoursPerKilogram(this float? value) => SpecificEnergy.FromKilowattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromKilowattHoursPerKilogram(double)"/>
        public static SpecificEnergy KilowattHoursPerKilogram(this decimal value) => SpecificEnergy.FromKilowattHoursPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEnergy.FromKilowattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? KilowattHoursPerKilogram(this decimal? value) => SpecificEnergy.FromKilowattHoursPerKilogram(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegajoulePerKilogram

        /// <inheritdoc cref="SpecificEnergy.FromMegajoulesPerKilogram(double)"/>
        public static SpecificEnergy MegajoulesPerKilogram(this int value) => SpecificEnergy.FromMegajoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegajoulesPerKilogram(double?)"/>
        public static SpecificEnergy? MegajoulesPerKilogram(this int? value) => SpecificEnergy.FromMegajoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegajoulesPerKilogram(double)"/>
        public static SpecificEnergy MegajoulesPerKilogram(this long value) => SpecificEnergy.FromMegajoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegajoulesPerKilogram(double?)"/>
        public static SpecificEnergy? MegajoulesPerKilogram(this long? value) => SpecificEnergy.FromMegajoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegajoulesPerKilogram(double)"/>
        public static SpecificEnergy MegajoulesPerKilogram(this double value) => SpecificEnergy.FromMegajoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegajoulesPerKilogram(double?)"/>
        public static SpecificEnergy? MegajoulesPerKilogram(this double? value) => SpecificEnergy.FromMegajoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegajoulesPerKilogram(double)"/>
        public static SpecificEnergy MegajoulesPerKilogram(this float value) => SpecificEnergy.FromMegajoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegajoulesPerKilogram(double?)"/>
        public static SpecificEnergy? MegajoulesPerKilogram(this float? value) => SpecificEnergy.FromMegajoulesPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegajoulesPerKilogram(double)"/>
        public static SpecificEnergy MegajoulesPerKilogram(this decimal value) => SpecificEnergy.FromMegajoulesPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEnergy.FromMegajoulesPerKilogram(double?)"/>
        public static SpecificEnergy? MegajoulesPerKilogram(this decimal? value) => SpecificEnergy.FromMegajoulesPerKilogram(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegawattHourPerKilogram

        /// <inheritdoc cref="SpecificEnergy.FromMegawattHoursPerKilogram(double)"/>
        public static SpecificEnergy MegawattHoursPerKilogram(this int value) => SpecificEnergy.FromMegawattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegawattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? MegawattHoursPerKilogram(this int? value) => SpecificEnergy.FromMegawattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegawattHoursPerKilogram(double)"/>
        public static SpecificEnergy MegawattHoursPerKilogram(this long value) => SpecificEnergy.FromMegawattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegawattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? MegawattHoursPerKilogram(this long? value) => SpecificEnergy.FromMegawattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegawattHoursPerKilogram(double)"/>
        public static SpecificEnergy MegawattHoursPerKilogram(this double value) => SpecificEnergy.FromMegawattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegawattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? MegawattHoursPerKilogram(this double? value) => SpecificEnergy.FromMegawattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegawattHoursPerKilogram(double)"/>
        public static SpecificEnergy MegawattHoursPerKilogram(this float value) => SpecificEnergy.FromMegawattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegawattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? MegawattHoursPerKilogram(this float? value) => SpecificEnergy.FromMegawattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromMegawattHoursPerKilogram(double)"/>
        public static SpecificEnergy MegawattHoursPerKilogram(this decimal value) => SpecificEnergy.FromMegawattHoursPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEnergy.FromMegawattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? MegawattHoursPerKilogram(this decimal? value) => SpecificEnergy.FromMegawattHoursPerKilogram(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region WattHourPerKilogram

        /// <inheritdoc cref="SpecificEnergy.FromWattHoursPerKilogram(double)"/>
        public static SpecificEnergy WattHoursPerKilogram(this int value) => SpecificEnergy.FromWattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromWattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? WattHoursPerKilogram(this int? value) => SpecificEnergy.FromWattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromWattHoursPerKilogram(double)"/>
        public static SpecificEnergy WattHoursPerKilogram(this long value) => SpecificEnergy.FromWattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromWattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? WattHoursPerKilogram(this long? value) => SpecificEnergy.FromWattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromWattHoursPerKilogram(double)"/>
        public static SpecificEnergy WattHoursPerKilogram(this double value) => SpecificEnergy.FromWattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromWattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? WattHoursPerKilogram(this double? value) => SpecificEnergy.FromWattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromWattHoursPerKilogram(double)"/>
        public static SpecificEnergy WattHoursPerKilogram(this float value) => SpecificEnergy.FromWattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromWattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? WattHoursPerKilogram(this float? value) => SpecificEnergy.FromWattHoursPerKilogram(value);

        /// <inheritdoc cref="SpecificEnergy.FromWattHoursPerKilogram(double)"/>
        public static SpecificEnergy WattHoursPerKilogram(this decimal value) => SpecificEnergy.FromWattHoursPerKilogram(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificEnergy.FromWattHoursPerKilogram(double?)"/>
        public static SpecificEnergy? WattHoursPerKilogram(this decimal? value) => SpecificEnergy.FromWattHoursPerKilogram(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif