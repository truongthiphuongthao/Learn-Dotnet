using System;

namespace Encapsulation
{
    class RectanglePublic
    {
        public double Length {get; set;}
        public double Width {get; set;}

        // constructor
        public RectanglePublic(){}

        public RectanglePublic(double Length, double Width){
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
