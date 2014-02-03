﻿// Copyright © 2007 by Initial Force AS.  All rights reserved.
// https://github.com/InitialForce/SIUnits
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

using UnitsNet.ThirdParty.Attributes;

namespace UnitsNet.ThirdParty
{
    public enum BarUnit
    {
        Undefined = 0,
 
        [Bar(slope: 1)] Bar,
        [Bar(slope: 2)] TwiceThanBar,
        [Bar(slope: 1, constant: 1, pluralName: "BarPlusOnes")] BarPlus1,
        [Bar(slope: 3, pluralName: "BarsTripled")] BarTripled,
    }

    public enum FooUnit
    {
        [Foo(slope: 1)] Foo,
        [Foo(slope: 2)] TwiceThanFoo,
        [Foo(slope: 1, constant: 2, pluralName: "FooPlusTwos")] FooPlus2,
        [Foo(slope: 4, pluralName: "FoosQuadrupled")] FooQuadrupled,
    }
}