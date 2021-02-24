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

    }
}
