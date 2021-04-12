using System;

namespace MethodOverloadingDemo
{
    class Addition
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }

    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            Addition obj = new Addition();
            Console.WriteLine(obj.Add(10, 20));
            Console.WriteLine(obj.Add(10.88888, 20.3322));
            Console.WriteLine(obj.Add(10, 20, 30));
        }
    }
}