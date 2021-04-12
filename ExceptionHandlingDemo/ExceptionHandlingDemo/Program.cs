using System;
using System.Xml.Schema;

namespace ExceptionHandlingDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] n = {10, 02, 40};
                Console.WriteLine(n[5]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot access non existing array index",e);
            }
            finally
            {
                Console.WriteLine("finally block is always performance ");
            }
            
            
            void CheckAge(int age)
            {
                if (age < 18) 
                {
                    throw new  ArithmeticException("You are not eligible");
                }
                else
                {
                    Console.WriteLine("you are eligible");
                }
            }
            CheckAge(20);
        }

        
    }
}