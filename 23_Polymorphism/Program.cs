using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Polymorphism
{
    class Employee
    {
        public string firstName = "FN";
        public string lastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " FullTime");
        }
    }
    class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " PartTime");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];
            emp[0] = new Employee();
            //emp[0].PrintFullName();
            emp[1] = new FullTimeEmployee();
            //emp[1].PrintFullName();
            emp[2] = new PartTimeEmployee();
            //emp[2].PrintFullName();

            // kudvenkat called with foreach PrintFullName method
            foreach (Employee employee in emp)
            {
                employee.PrintFullName();
            }
            Console.ReadLine();
        }
    }
}
