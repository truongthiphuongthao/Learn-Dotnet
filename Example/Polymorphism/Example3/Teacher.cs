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

    }
}
