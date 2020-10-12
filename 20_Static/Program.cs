using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// class Circle, static double Pi = 3.14, კონსტრუქტორში გადავცეთ რადიუსი, შევქმნათ ფართობის
// გამოთვლის მეთოდი და გამოვიძახოთ 2 ობიექტისთვის

namespace _20_Static
{
    class Circle
    {
        static double Pi = 3.14;
        private int _radius;
        public Circle(int radius)
        {
            this._radius = radius;
        }
        public void CircleArea()
        {
            Console.WriteLine(Pi * _radius * _radius);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            circle1.CircleArea();

            Circle circle2 = new Circle(6);
            circle2.CircleArea();

            Console.ReadLine();
        }
    }
}
