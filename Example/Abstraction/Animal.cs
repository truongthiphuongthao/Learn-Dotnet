using System;

namespace Abstraction
{
    abstract class Animal
    {
      // abstract method
      public abstract void Sound();

      // virtual method
      public virtual void Eat(){
        Console.WriteLine("Eat grass");
      }

      // normal method
      public void Run(){
        Console.WriteLine("Can run");
      }
    }
}
