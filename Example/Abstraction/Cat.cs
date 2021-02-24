using System;

namespace Abstraction
{
    class Cat: Animal
    {
        public override void Sound(){
          Console.WriteLine("Meow");
        }

        public override void Eat(){
          Console.WriteLine("Eat fishs");
        }
    }
}
