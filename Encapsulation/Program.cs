using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // access RectanglePublic
            Console.WriteLine("-------Access Public--------");
            RectanglePublic rePublic = new RectanglePublic();
            rePublic.Length = 4.0;
            rePublic.Width = 5.0;
            rePublic.Display();

            // access RectanglePrivate
            Console.WriteLine("-------Access Private--------");
            RectanglePrivate rePrivate = new RectanglePrivate(4.0, 5.0);
            rePrivate.Display();

            // access RectangleProtected
            Console.WriteLine("------Access Protected-------");
            RectangleProtected reProtected = new RectangleProtected(4.0, 5.0);
            reProtected.Display();

            // access protected with inherit
            Console.WriteLine("------Access Protected Inherit------");
            Shape shape = new Shape();
            shape.setLength(4.0);
            shape.setWidth(5.0);
            shape.Display();
            Rectangle rectangle = new Rectangle();
            rectangle.setLength(6.0);
            rectangle.setWidth(5.0);
            rectangle.Display();
            Console.WriteLine("Get area: {0} ", rectangle.getArea());

        }
    }
}
