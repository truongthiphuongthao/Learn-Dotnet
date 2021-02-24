using System;

namespace Example3
{
    class Lecturer : Employee
    {
      public Lecturer(){
        position = "Lecturer";
      }

      public Lecturer(String code, String name, String address, String position, double salary)
        : base(code, name, address, position, salary){}

      public override double calculateSalary(){
        return salary * 1000;
      }

      public override void displayInformation(){
        Console.WriteLine("-------Display information Lecturer---------");
        base.displayInformation();
        Console.WriteLine("Position: {0}", position);
        Console.WriteLine("Salary: {0}", calculateSalary());
      }

    }
}
