using System;

namespace InterfaceDemo
{
    interface IAnimal
    {
        void Eat(); //By default interface members are public abstract
    }
    class Program : IAnimal
    {
        // Do not use override keyword while overriding the method
         public void Eat() //check this by removing the access modifier
        {
            Console.WriteLine("Eating....");
        }
        public static void Main(string[] args)
        {
            IAnimal ia = new IAnimal(); // Cannot create instace of interface
            Program obj = new Program();
            obj.Eat();
        }
    }
}