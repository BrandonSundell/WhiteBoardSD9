using System;

namespace SimpleGeometry
{
    class Program
    {
        static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Geometry Test.");
            double R = 10.0;
            Console.WriteLine($"Are of the circle with r={R} is {AreaOfCircle(R)}");
           
        }
    }
}
