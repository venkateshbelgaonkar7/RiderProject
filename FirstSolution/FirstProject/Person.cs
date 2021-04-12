using System;


namespace FirstProject
{
    public class Person
    {
        public string Name = "Venkatesh";
        private int _salary = 10;

        public void Introduce()
        {
            Console.WriteLine("Hello, My name is " + Name + " " + _salary);
        }
        
    }
}