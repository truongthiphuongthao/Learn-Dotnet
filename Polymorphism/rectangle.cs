using System;

namespace Polymorphism
{
    class Rectangle
    {
      public double Length {get; set;}
      public double Width {get; set;}

      public Rectangle(double Length, double Width){
        this.Length = Length;
        this.Width = Width;
      }

      public void Resize(int SameSize){
        this.Length = SameSize;
        this.Width = SameSize;
      }

      public void Resize(int Length, int Width){
        this.Length = Length;
        this.Width = Width;
      }

      public double getArea(double Length, double Width){
        return Length * Width;
      }

      public int getArea(int Length){
        return Length * 4;
      }

      public int getArea(int Length, int Width){
        return Length * Width;
      }

      public void Display(){
        Console.WriteLine("Length: {0}", Length);
        Console.WriteLine("Width: {0}", Width);
      }

    }
}
