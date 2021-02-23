using System;

namespace Encapsulation
{
  class RectangleProtected
  {
    protected double Length {get; set;}
    protected double Width {get; set;}

    public RectangleProtected(){}

    public RectangleProtected(double Length, double Width){
      this.Length = Length;
      this.Width = Width;
    }

    public double getArea(){
      return Length * Width;
    }

    public void Display(){
      Console.WriteLine("Length: {0}", Length);
      Console.WriteLine("Width: {0}", Width);
      Console.WriteLine("Get Area: {0}", getArea());
    }
  }
}
