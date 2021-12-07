using System;
using vectores;

namespace ConsoleVec
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] asd = new int[4];
            for (int i = 0; i < asd.Length; i++)
            {
                asd[i] = int.Parse(Console.ReadLine());
            }
            Vector vector = new Vector(asd[0],asd[1]);
            Vector vector2 = new Vector(asd[2], asd[3]);
            Console.WriteLine(vector+" "+vector.Magnitude());
            Console.WriteLine(vector2 + " " + vector2.Magnitude());
            Console.WriteLine(vector.DotProduct(vector2));
            Console.WriteLine(vector.AngleBetween(vector2));
        }
    }
}
