using System;

namespace Inheritance
{
    class Shape
    {
      public int Length {get; set;}
      public int Width {get; set;}

      public void Display(){
        Console.WriteLine("Length: {0}", Length);
        Console.WriteLine("Width: {0}", Width);
      }
    }
}
