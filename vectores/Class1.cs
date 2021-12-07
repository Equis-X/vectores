using System;

namespace vectores
{
    public class Vector
    {
        public int x { get; set; }
        public int y { get; set; }
        public Vector(int f, int s)
        {
            x = f;
            y = s;
        }
        public double Magnitude()
        {
            return Math.Sqrt(Math.Pow(x, 2)+ Math.Pow(y, 2));
        }
        public double DotProduct(Vector v)
        {
            return (v.x * x) + (v.y * y);
        }
        public double AngleBetween(Vector v)
        {
            double temp = DotProduct(v)/(Magnitude()*v.Magnitude());
            return Math.Acos(temp);
        }
    }
}
