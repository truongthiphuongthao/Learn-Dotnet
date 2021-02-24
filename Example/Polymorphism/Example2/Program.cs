using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            cat.Sound();

            Animal dog = new Dog();
            dog.Sound();
        }
    }
}
