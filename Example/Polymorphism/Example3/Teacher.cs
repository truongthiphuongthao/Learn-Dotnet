using System;

namespace Example3
{
    class Teacher : Employee
    {
      public Teacher(){
        position = "Teacher";
      }

      public Teacher(String code, String name, String address, String position, double salary)
        : base(code, name, address, position, salary){}

      public override double calculateSalary(){
        return salary * 600;
      }

      public override void displayInformation(){
        Console.WriteLine("------------Display information Teacher----------");
        base.displayInformation();
        Console.WriteLine("Position: {0}", position);
        Console.WriteLine("Salary: {0}", calculateSalary());
      }

    }
}
