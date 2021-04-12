using System;
using System.Collections;

namespace ArrayListDemo1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ArrayList al = new ArrayList(2);
            al.Add("Hello");
            Console.WriteLine(al.Capacity);
            al.Add(6);
            al.Add(20.55);
            al.Add(true);
            Console.WriteLine(al.Capacity);
            al.Add(100);
            al.Remove(6);
            al.RemoveAt(0);
            al.Insert(0,22);
            Console.WriteLine(al.Capacity);
            Console.WriteLine("ArrayList Count "+al.Count);
            Console.WriteLine(al.IsFixedSize);
            al.Clear();
            foreach (object var in al)
            {
                Console.Write(var+" ");
            }
            
        }
    }
}