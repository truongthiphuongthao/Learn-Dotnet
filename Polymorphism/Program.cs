using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("-------Overloading------");
          Rectangle rectangle = new Rectangle(5.0, 6.0);
          rectangle.Display();
          rectangle.Resize(5);
          rectangle.Display();
          Console.WriteLine("Get area: {0}", rectangle.getArea(5));
          rectangle.Resize(5,6);
          rectangle.Display();
          Console.WriteLine("Get area: {0}", rectangle.getArea(5, 6));
          Console.WriteLine("-------Overriding-------");
          Animal animal = new Animal();
          animal.Sound();
          Animal cat = new Cat();
          cat.Sound();
        }
    }
}
