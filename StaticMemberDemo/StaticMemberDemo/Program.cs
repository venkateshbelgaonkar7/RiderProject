using System;
using System.Runtime.InteropServices;

namespace StaticMemberDemo
{
    public class Program
    {
        private static readonly string name = "Venkatesh"; // class variable (static member)
        public static void Main(string[] args) //class method (static member)
        {
            Run();
            MyClass.Walk();
            name = "hello";
        }
        
        static void Run() //class method
        {
            Console.WriteLine("Running.....");
            Console.WriteLine(Program.name);
        }
    }

    class MyClass
    {
        public static void Walk() // class Method
        {
            Console.WriteLine("Walking.....");
            Console.WriteLine();
        }
    }
}