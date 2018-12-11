﻿using GeometricFigures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NUnit.Tests
{
    [TestFixture]
    public class TestClassCircle
    {
        static object[] DivideCases =
        {
            new object[] { 0 },
            new object[] { 1 },
            new object[] { 2 },
            new object[] { 3 },
            new object[] { 4 },
            new object[] { 5 },
            new object[] { 6 },
            new object[] { 7 },
            new object[] { 8 },
            new object[] { 9 },
            new object[] { 10 },
            new object[] { 11 },
            new object[] { 12 },
            new object[] { 13 },
            new object[] { 14 },
            new object[] { 15 },
            new object[] { 16 },
            new object[] { 17 },
            new object[] { 18 },
            new object[] { 19 },
            new object[] { 20 }
        };
        [TestCaseSource("DivideCases")]
        public void Test_Area_Circle(int x)
        {
            Circle z = new Circle(x);
            Assert.AreEqual(Math.Round(3.1416 * x * x, 0), Math.Round(z.getAreaCircle(), 0));
        }
        [TestCaseSource("DivideCases")]
        public void Test_Length_Circle(int x)
        { 
            Circle z = new Circle(x);
            Assert.AreEqual(Math.Round(3.1416 * (x + x), 0), Math.Round(z.getLengthCircle(), 0));
        }

    }
}
