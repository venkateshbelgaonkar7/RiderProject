using System;
using System.Collections.Generic;

namespace ListGenericDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(20);
            li.Add(10);
            li.Add(50);
            li.Add(33);
            li.Add(40);
            li.Sort();
            li.Reverse();
            foreach (int i in li)
            {   
                Console.WriteLine(i);
            }
        }


        
    }
}