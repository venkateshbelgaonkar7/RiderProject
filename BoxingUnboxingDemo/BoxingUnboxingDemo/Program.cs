using System;

namespace BoxingUnboxingDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // int num = 23;
            // object obj = num;
            // Console.WriteLine(num);
            // Console.WriteLine(obj);

            int num = 20;
            object obj = num;
            int a = (int) obj;
        }
    }
}