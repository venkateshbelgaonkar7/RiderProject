using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace DictionarryDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "venka");
            dct.Add(2, "pooja");
            dct.Add(3, "priya");
            dct.Add(4, "shreya");
            dct.Add(5, "shrusti");
            dct.Add(6, "susmita");
            dct.Add(7, "vivek");
            dct.Remove(1);
            Console.WriteLine(dct.Count);
            Console.WriteLine(dct.ContainsKey(3));
            Console.WriteLine(dct.Keys);
            Console.WriteLine(dct.Values);
            
            

        }
    }
}