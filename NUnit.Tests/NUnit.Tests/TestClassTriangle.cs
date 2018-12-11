using GeometricFigures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests
{
    [TestFixture]
    public class TestClassTriangle
    {
        static object[] DivideCases = getMass();
        public static object[] getMass()
        {
            List<object[]> test = new List<object[]>();
            for (int x = 0; x <= 20; x++)
                for (int y = 0; y <= 20; y++)
                    for (int z = 0; z <= 20; z++)
                    {
                        if (x + y > z && x + z > y && z + y > x)
                        {
                            test.Add(new object[] { x, y, z });
                        }
                    }
            return test.ToArray();
        }
        [TestCaseSource("DivideCases")]
        public void Test_Area_Triangle(int x, int y, int z)
        {
            Triangle a = new Triangle(x, y, z);
            Assert.AreEqual(Math.Sqrt(((x + y + z) / 2) * (((x + y + z) / 2) - x) * (((x + y + z) / 2) - y) * (((x + y + z) / 2) - z)), a.getAreaTriangle());
        }
        [TestCaseSource("DivideCases")]
        public void Test_Length_Triangle(int x, int y, int z)
        {
            Triangle a = new Triangle(x, y, z);
            Assert.AreEqual(x + y + z, a.getLengthTriangle());
        }
    } 
}