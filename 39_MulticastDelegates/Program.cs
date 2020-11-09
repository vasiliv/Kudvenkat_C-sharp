using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_MulticastDelegates
{
    delegate void MulticastDelegate ();
    class Program
    {
        static void Main(string[] args)
        {
            //MulticastDelegate del1 = new MulticastDelegate(MethodOne);
            //MulticastDelegate del2 = new MulticastDelegate(MethodTwo);
            //MulticastDelegate del3 = new MulticastDelegate(MethodThree);
            //MulticastDelegate del4 = del1 + del2 + del3;

            // or alternative way
            MulticastDelegate del4 = new MulticastDelegate(MethodOne);
            del4 += MethodTwo;
            del4 += MethodThree;
            
            del4.Invoke();
             
            Console.ReadLine();
        }
        public static void MethodOne()
        {
            Console.WriteLine("Method One");
        }
        public static void MethodTwo()
        {
            Console.WriteLine("Method Two");
        }
        public static void MethodThree()
        {
            Console.WriteLine("Method Three");
        }
    }
}
