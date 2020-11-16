using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = Add(10, 11);
            Console.ReadKey();
        }
        static bool Add <T>(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
