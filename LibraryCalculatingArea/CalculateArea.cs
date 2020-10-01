using System;

namespace LibraryCalculatingArea
{
    public class CalculateArea
    {

        //площадь окружности
        public double AreaCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }


        //площадь треугольника
        public (double result, bool recrectangular) AreaTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                return (s, true);
            }
            else
            {
                return (s, false);
            }
        }
    }
}
