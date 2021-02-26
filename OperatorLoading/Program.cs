using System;

namespace OperatorLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(6, 7, 5);
            Box box2 = new Box(12, 13, 10);
            Box box3 = new Box();
            box3 = box1 + box2;
            box3.Display();
        }
    }
}
