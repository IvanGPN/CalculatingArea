using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCalculatingArea;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCircle()
        {
            LibraryCalculatingArea.CalculateArea calculate = new CalculateArea();
            double radius = 2.3;
            double areaC = calculate.AreaCircle(radius);
            Assert.AreEqual(areaC, Math.PI * Math.Pow(2.3, 2));
        }

        [TestMethod]
        public void TestMethodTriangle()
        {
            LibraryCalculatingArea.CalculateArea calculate = new CalculateArea();
            double a = 3;
            double b = 4;
            double c = 5;
            Tuple<double, bool> areaT = calculate.AreaTriangle(a, b, c).ToTuple<double, bool>();
            
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Tuple<double, bool> res = Tuple.Create(s, true);

            Assert.AreEqual(areaT, res);
        }
    }
}
