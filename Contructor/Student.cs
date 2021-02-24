using System;

namespace Contructor
{
    class Student
    {
        private String name;
        private int age;
        private double salary;

        //public Student(){}

        public void Display(){
          Console.WriteLine("Name: {0}", name);
          Console.WriteLine("Age: {0}", age);
          Console.WriteLine("Salary: {0}", salary);
        }

    }
}
