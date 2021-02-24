using System;

namespace Abstraction
{
    class Dog: Animal
    {
        public override void Sound(){
          Console.WriteLine("Gau gau");
        }

        public override void Eat(){
          Console.WriteLine("Eat bones");
        }
    }
}
