using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
          Animal dog = new Dog();
          dog.Sound();
          dog.Eat();
          dog.Run();

          Animal cat = new Cat();
          cat.Sound();
          cat.Eat();
          cat.Run();

        }
    }
}
