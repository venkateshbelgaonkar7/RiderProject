using System;

namespace AccessDemo1
{
    class Vehicle
    {
        public static void Main(string[] args)
        {
            Vehicle obj = new Vehicle();
            obj.name = "heelll";
            Console.WriteLine(obj.name);
        }
        
    }

    class Car
    {
        protected string name = "prius";
        
        
    }


}