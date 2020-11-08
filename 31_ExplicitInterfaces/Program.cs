using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_ExplicitInterfaces
{
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }
    class Program : I1, I2
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("Interface1 method");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("Interface2 method");
        }
        static void Main(string[] args)
        {
            I1 program1 = new Program();
            program1.InterfaceMethod();

            in

            Program program = new Program();
            ((I2)program).InterfaceMethod();

            Console.ReadKey();
        }
    }
}
