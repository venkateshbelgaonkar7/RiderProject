using System;

namespace FirstProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a/b;
                Console.WriteLine("Value = %d", c);
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                string s = null;
                Console.WriteLine(s.ToUpper());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }

            try
            {
                int[] ar = {10, 20, 30};
                Console.WriteLine("Vale = %d", ar[5]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try 
            {
                int a = 10;
                Object obj = a;
                byte b = (byte)obj;
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally is always executed");
            }
            
        }
    }
}