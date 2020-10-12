using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// დავწეროთ ისეთი მეთოდი რომელიც იღებს მთელ არგუმენტს და იმ არგუმენტის ჩათვლით
// ამობეჭდავს ლუწ ციფრებს


namespace _17_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenNumbers(30);
            Console.ReadLine();
        }
        static void EvenNumbers(int j)
        {
            for (int i = 0; i <=j; i+=2)
            {
                Console.WriteLine(i);
            }
        }

    }
}
