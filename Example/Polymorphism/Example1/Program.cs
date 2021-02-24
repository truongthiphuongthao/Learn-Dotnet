using System;

namespace Example1
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
