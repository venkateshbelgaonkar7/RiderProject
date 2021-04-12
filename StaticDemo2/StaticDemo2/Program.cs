using System;

namespace StaticDemo2
{
    class Circle
    {
        static readonly double PI = 3.14;
        int radius;

        public Circle(int value, double pi)
        {
            radius = value;
            // PI = pi;
        }

        static Circle()
        {
            PI = 20;
        }

        public void Compute()
        { 
            double result = 2 * PI * (radius * radius);
            Console.WriteLine("Area of cirlce "+result);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle obj = new Circle(10, 20);
            obj.Compute();
            
        }
    }
}