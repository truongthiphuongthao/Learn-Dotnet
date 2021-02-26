using System;

namespace OperatorLoading
{
    class Box
    {
      public double Length;
      public double Breadth;
      public double Height;

      // constructor
      public Box(){}

      public Box(double Length, double Breadth, double Height){
        this.Length = Length;
        this.Breadth = Breadth;
        this.Height = Height;
      }

      // nap chong phep cong
      public static Box operator + (Box b, Box c){
          Box box = new Box();
          Length = b.Length + c.Length;
          Breadth = b.Breadth + c.Breadth;
          Height = b.Height + c.Height;
          return box;
      }

      public void Display(){
        Console.WriteLine("Length: {0}", Length);
        Console.WriteLine("Breadth: {0}", Breadth);
        Console.WriteLine("Height: {0}", Height);
      }

    }
}
