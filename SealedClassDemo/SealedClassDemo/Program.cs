using System;

namespace SealedClassDemo
{
    public sealed class A
    {
        public void Run()
        {
            Console.WriteLine("Running....");
        }
    }
    class Program : A
    {
        public static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Run();
        }
    }
}