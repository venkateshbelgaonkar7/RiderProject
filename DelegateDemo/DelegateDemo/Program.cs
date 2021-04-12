using System;

namespace DelegateDemo
{

    public delegate void AddDelegate(int a, int b);

    public delegate string SayHelloDelegate(string name);
    class Program
    {

        public void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }

        static string SayHello(string name)
        {
            return "Hello" + name;
        }
        public static void Main(string[] args)
        {
            Program p1 = new Program();
            AddDelegate ad = new AddDelegate(p1.Add);
            ad(10, 20);
                
            SayHelloDelegate shd = new SayHelloDelegate(SayHello);
            Console.WriteLine(shd("hello"));
        }
        
    }

    
}