using System;
using System.ComponentModel;

namespace ConstructorDemo
{ //Copy Constructor
    public class Program
    {
        int x;
        int y;
        public Program(int i)
        {
            x = i;
        }

        public Program(Program obj)
        {
            y = obj.x;
        }

        public void Display()
        {
            Console.WriteLine("VAlue of x "+x);
            Console.WriteLine("Value of y "+y);
        }
        
        public static void Main(string[] args)
        {
            Program p1 = new Program(10);
            p1.Display();
            Program p2 = new Program(p1);
            p2.Display();
        }
    }
}