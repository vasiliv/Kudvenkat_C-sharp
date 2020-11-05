using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Inheritance
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("default parent constructor");
        }
        public Parent(string parent)
        {
            Console.WriteLine(parent);
        }
    }
    class Child : Parent
    {
        public Child():base("Vasil")
        {
            Console.WriteLine("default child constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child petre = new Child();
            Console.ReadLine();
        }
    }
}
