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
            SwapOut(a, b, out a, out b);
            Console.WriteLine("a: " + a + " b: " + b);
        }
       static void SwapRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void SwapOut(int a, int b, out int c, out int d)
        {
            // a = 2 , b = 4 => a = 4, b = 2;
            c = a;
            d = b;
        }
    }
}
