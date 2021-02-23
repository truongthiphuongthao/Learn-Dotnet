using System;

namespace Encapsulation
{
  class Shape
  {
    protected double Length;
    protected double Width;

    public Shape(){}

    public Shape(double Length, double Width){
      this.Length = Length;
      this.Width = Width;
    }

    public void setLength(double Length){
      this.Length = Length;
    }

    public void setWidth(double Width){
      this.Width = Width;
    }

    public void Display(){
      Console.WriteLine("Length: {0}", Length);
      Console.WriteLine("Width: {0}", Width);

    }
  }
}
