using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;
            SwapRef(ref a, ref b);
            Console.WriteLine("a: " + a + " b: " + b);
            SwapOut(out a, out b);
            Console.WriteLine("a: " + a + " b: " + b);
        }
       static void SwapRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void SwapOut(out int a, out int b)
        {
            int temp =  a;
            a = b ;
            b = temp;
        }
    }
}
