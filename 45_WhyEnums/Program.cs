using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 0 - Unknown
// 1 - Male
// 2 - Female
// Create class Customer, Create 3 member array of Customer type and initialize
// Create public static string GetGender(int gender) method to differ sex

namespace _45_WhyEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[2];

            //customers[0].Name = "Vasil";
            //customers[0].Gender = 1;

            //customers[1].Name = "Ana";
            //customers[1].Gender = 2;
            customers[0] = new Customer
            {
                Name = "Vasil",
                Gender = 1
            };
            customers[1] = new Customer
            {
                Name = "Ana",
                Gender = 2
            };

            foreach (Customer cust in customers)
            {
                Console.WriteLine("Name = {0} Gender = {1}", cust.Name, cust.GetGender(cust.Gender));
            }
            Console.ReadLine();
        }
    }
    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }

        public string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return ("Unknown");
                case 1:
                    return ("Male");
                case 2:
                    return ("Female");
                default:
                    return ("No such a value");
            }
        }
        //public string GetGender(CheckGender gender)
        //{
        //    switch (gender)
        //    {
        //        case CheckGender.Unknown:
        //            return ("Unknown");
        //        case CheckGender.Male:
        //            return ("Male");
        //        case CheckGender.Female:
        //            return ("Female");
        //        default:
        //            return ("No such a value");
        //    }
        //}
        //public enum CheckGender
        //{
        //    Unknown = 0,
        //    Male = 1,
        //    Female = 2
        //}
    }

}
