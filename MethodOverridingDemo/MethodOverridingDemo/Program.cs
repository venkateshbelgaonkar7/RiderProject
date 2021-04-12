using System;

namespace MethodOverridingDemo
{
    class Vehicle
    {
        public virtual void Moves()
        {
            Console.WriteLine("Vehicle is moving.....");
        }
    }
    class Program : Vehicle
    {
        public override void Moves()
        {
            Console.WriteLine("Car is moving");
        }
        public static void Main(string[] args)
        {
            Program c = new Program();
            c.Moves();
        }
    }
}