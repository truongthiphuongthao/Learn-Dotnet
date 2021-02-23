using System;

namespace Encapsulation
{
  class RectanglePrivate
  {
    private double Length {get; set;}
    private double Width {get; set;}

    // constructor

    public RectanglePrivate(){}

    public RectanglePrivate(double Length, double Width){
      this.Length = Length;
      this.Width = Width;
    }

    public double getArea(){
      return Length * Width;
    }

    public void Display(){
      Console.WriteLine("Length: {0}", Length);
      Console.WriteLine("Width: {0}", Width);
      Console.WriteLine("Get area: {0}", getArea());
    }
  }
}
