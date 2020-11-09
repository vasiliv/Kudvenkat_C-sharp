using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 

namespace _36_Delegates
{
    public delegate void MyDelegate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Hello);
            //Hello("Hello Vasil");
            myDelegate("Hello Vasil");
            Console.ReadLine();
        }
        public static void Hello(string strMessge)
        {
            Console.WriteLine(strMessge);
        }
    }
}
