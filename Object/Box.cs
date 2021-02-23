using System;

namespace Object
{
    class Box
    {
        // properties
        public double Length {get; set;}
        public double Breadth {get; set;}
        public double Height {get; set;}

        public Box(){}

        public Box(double Length, double Breadth, double Height){
        	this.Length = Length;
        	this.Breadth = Breadth;
        	this.Height = Height;
        }

        public void Print(){
        	Console.WriteLine("Length = {0}, Breadth = {1}, Height = {2}", Length, Breadth, Height);
        }
    }
}
