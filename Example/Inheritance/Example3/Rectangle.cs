using System;

namespace Example3
{
    class Rectangle : Shape
    {
        public Rectangle(){}

        public Rectangle(int Length, int Width)
        : base(Length, Width){}

        public int getArea(){
          return Length * Width;
        }

        public override void display(){
          base.display();
          Console.WriteLine("Get area: {0}", getArea());
        }

    }
}
