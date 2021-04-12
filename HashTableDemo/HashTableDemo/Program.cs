using System;
using System.Collections;

namespace HashTableDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("name", "Avinash");
            ht.Add("salary", 200000);
            ht.Add("Age", 25);
            ht.Add("company", "google");
            ht.Remove("name");

            foreach (DictionaryEntry i in ht)
            {
                Console.Write(i.Key+" "+i.Value);
            }
            
        }
    }
}