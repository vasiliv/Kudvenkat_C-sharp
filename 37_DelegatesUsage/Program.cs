﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 37 and 38

// class Employee, autoimplemented properties Id, Name, Salary, Experience,
// method PromoteEmployee which take list of employees as an argument, and returns nothing
// foreach - if - experience > 5 - promote
// main - create new list of employees and add some employees, call PromoteEmployee
namespace _37_DelegatesUsage
{
    delegate bool IsPromotable(Employee employee);
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee {Id = 1, Name = "Vasil", Salary = 50000, Experience =10 });
            employee.Add(new Employee { Id = 2, Name = "Lile", Salary = 5000, Experience = 2 });
            employee.Add(new Employee { Id = 3, Name = "Petre", Salary = 500, Experience = 1 });

            //Employee.PromoteEmployee(employee);
            IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(employee, isPromotable);

            Console.ReadLine();
        }
        public static bool Promote(Employee emp)
        {
            if (emp.Experience > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        //public static void PromoteEmployee(List <Employee> emp)
        //{
        //    foreach (Employee employee in emp)
        //    {
        //        if (employee.Experience > 5)
        //        {
        //            Console.WriteLine(employee.Name + " Promoted");
        //        } 
        //    }
        //}
        public static void PromoteEmployee(List<Employee> emp, IsPromotable isPromotable)
        {
            foreach (Employee employee in emp)
            {
                if (isPromotable(employee)) // delegate
                {
                    Console.WriteLine(employee.Name + " Promoted");
                }
            }
        }
    }
}
