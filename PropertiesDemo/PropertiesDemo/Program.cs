using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PropertiesDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            First obj = new First();
            obj.Name = "HEllo";
            Console.WriteLine(obj.Name);       
        }
    }

    class First
    { 
        private string name = "Venkatesh";

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        
            
    }

    
}