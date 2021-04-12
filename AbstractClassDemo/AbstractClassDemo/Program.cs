using System;

namespace AbstractClassDemo
{
    abstract class Animal
    {
        public abstract void Sleep(); //Abstract method with definition

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    
    // IMPORTANT! use oveeride keyword
    class Dog : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("Sleeping....");   
        }
        public static void Main(string[] args)
        {
            Animal obj = new Animal(); // Cannot create the object of Animal class

        }
    }
}