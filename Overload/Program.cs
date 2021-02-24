using System;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo demo1 = new Demo();
            Console.WriteLine("Sum: {0}", demo1.Sum(4,5));
            Console.WriteLine("Sum: {0}", demo1.Sum(4.2, 5.3));
        }
    }
}
