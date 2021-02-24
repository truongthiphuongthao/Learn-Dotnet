using System;

namespace Example3
{
    class Shape
    {
        protected int Length;
        protected int Width;

        public Shape(){}

        public Shape(int Length, int Width){
          this.Length = Length;
          this.Width = Width;
        }

        public void input(){
          Console.WriteLine("Enter input");
          Console.Write("Length: ");
          Length = Convert.ToInt32(Console.ReadLine());
          Console.Write("Width: ");
          Width = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void display(){
          Console.WriteLine("Display: ");
          Console.WriteLine("Length: {0}", Length);
          Console.WriteLine("Width: {0}", Width);
        }


    }
}
