using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
          // lop cha
          Shape shape = new Shape();
          shape.Length = 4;
          shape.Width = 5;
          shape.Display();
          // lop con
           Rectangle re = new Rectangle();
           re.Length = 4;
           re.Width = 5;
           Console.WriteLine("Get area: {0} ", re.getArea());
           re.Display();
        }
    }
}
