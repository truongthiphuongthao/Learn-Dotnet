using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee teacher = new Teacher();
            teacher.inputInformation();
            teacher.displayInformation();

            Employee lecturer = new Lecturer();
            lecturer.inputInformation();
            lecturer.displayInformation();
        }
    }
}
