using System;

namespace Example3
{
    class Employee
    {
        protected String code;
        protected String name;
        protected String address;
        protected String position;
        protected double salary;

        public Employee(){}

        public Employee(String code, String name, String address, String position, double salary){
          this.code = code;
          this.name = name;
          this.address = address;
          this.position = position;
          this.salary = salary;
        }

        public void inputInformation(){
          Console.WriteLine("Enter Information");
          Console.Write("Code: ");
          code = Console.ReadLine();
          Console.Write("Name: ");
          name = Console.ReadLine();
          Console.Write("Address: ");
          address = Console.ReadLine();
          Console.Write("Salary: ");
          salary = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void displayInformation(){
          Console.WriteLine("Code: {0}", code);
          Console.WriteLine("Name: {0}", name);
          Console.WriteLine("Address: {0}", address);
        }

        public virtual double calculateSalary(){
          return salary;
        }

    }
}
