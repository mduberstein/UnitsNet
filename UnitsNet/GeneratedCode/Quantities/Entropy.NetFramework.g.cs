﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
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
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Entropy is an important concept in the branch of science known as thermodynamics. The idea of "irreversibility" is central to the understanding of entropy.  It is often said that entropy is an expression of the disorder, or randomness of a system, or of our lack of information about it. Entropy is an extensive property. It has the dimension of energy divided by temperature, which has a unit of joules per kelvin (J/K) in the International System of Units
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct Entropy : IComparable, IComparable<Entropy>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable Entropy from nullable CaloriesPerKelvin.
        /// </summary>
        public static Entropy? FromCaloriesPerKelvin(QuantityValue? caloriesperkelvin)
        {
            return caloriesperkelvin.HasValue ? FromCaloriesPerKelvin(caloriesperkelvin.Value) : default(Entropy?);
        }

        /// <summary>
        ///     Get nullable Entropy from nullable JoulesPerDegreeCelsius.
        /// </summary>
        public static Entropy? FromJoulesPerDegreeCelsius(QuantityValue? joulesperdegreecelsius)
        {
            return joulesperdegreecelsius.HasValue ? FromJoulesPerDegreeCelsius(joulesperdegreecelsius.Value) : default(Entropy?);
        }

        /// <summary>
        ///     Get nullable Entropy from nullable JoulesPerKelvin.
        /// </summary>
        public static Entropy? FromJoulesPerKelvin(QuantityValue? joulesperkelvin)
        {
            return joulesperkelvin.HasValue ? FromJoulesPerKelvin(joulesperkelvin.Value) : default(Entropy?);
        }

        /// <summary>
        ///     Get nullable Entropy from nullable KilocaloriesPerKelvin.
        /// </summary>
        public static Entropy? FromKilocaloriesPerKelvin(QuantityValue? kilocaloriesperkelvin)
        {
            return kilocaloriesperkelvin.HasValue ? FromKilocaloriesPerKelvin(kilocaloriesperkelvin.Value) : default(Entropy?);
        }

        /// <summary>
        ///     Get nullable Entropy from nullable KilojoulesPerDegreeCelsius.
        /// </summary>
        public static Entropy? FromKilojoulesPerDegreeCelsius(QuantityValue? kilojoulesperdegreecelsius)
        {
            return kilojoulesperdegreecelsius.HasValue ? FromKilojoulesPerDegreeCelsius(kilojoulesperdegreecelsius.Value) : default(Entropy?);
        }

        /// <summary>
        ///     Get nullable Entropy from nullable KilojoulesPerKelvin.
        /// </summary>
        public static Entropy? FromKilojoulesPerKelvin(QuantityValue? kilojoulesperkelvin)
        {
            return kilojoulesperkelvin.HasValue ? FromKilojoulesPerKelvin(kilojoulesperkelvin.Value) : default(Entropy?);
        }

        /// <summary>
        ///     Get nullable Entropy from nullable MegajoulesPerKelvin.
        /// </summary>
        public static Entropy? FromMegajoulesPerKelvin(QuantityValue? megajoulesperkelvin)
        {
            return megajoulesperkelvin.HasValue ? FromMegajoulesPerKelvin(megajoulesperkelvin.Value) : default(Entropy?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="EntropyUnit" /> to <see cref="Entropy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Entropy unit value.</returns>
        public static Entropy? From(QuantityValue? value, EntropyUnit fromUnit)
        {
            return value.HasValue ? new Entropy((double)value.Value, fromUnit) : default(Entropy?);
        }

        #endregion

        #region Arithmetic Operators

        public static Entropy operator -(Entropy right)
        {
            return new Entropy(-right.Value, right.Unit);
        }

        public static Entropy operator +(Entropy left, Entropy right)
        {
            return new Entropy(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Entropy operator -(Entropy left, Entropy right)
        {
            return new Entropy(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Entropy operator *(double left, Entropy right)
        {
            return new Entropy(left * right.Value, right.Unit);
        }

        public static Entropy operator *(Entropy left, double right)
        {
            return new Entropy(left.Value * right, left.Unit);
        }

        public static Entropy operator /(Entropy left, double right)
        {
            return new Entropy(left.Value / right, left.Unit);
        }

        public static double operator /(Entropy left, Entropy right)
        {
            return left.JoulesPerKelvin / right.JoulesPerKelvin;
        }

        #endregion

        public static bool operator <=(Entropy left, Entropy right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Entropy left, Entropy right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Entropy left, Entropy right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Entropy left, Entropy right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Entropy left, Entropy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Entropy left, Entropy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
    }
}
