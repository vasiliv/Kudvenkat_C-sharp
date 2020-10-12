using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Class customer. firstName, lastName. გადავცეთ default კონსტრუქტორიდან user defined
// კონსტრუქტორს this keyword-ის გამოყენებით და ამოვბეჭდოთ

namespace _19_Classes
{
    class Customer
    {
        private string _firstName, _lastName;
        public Customer() : this ("Vasil", "Ivanishvili")
        {

        }
        public Customer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public void PrintCustomer()
        {
            Console.WriteLine("Customer name is: {0}, {1}", _firstName, _lastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.PrintCustomer();

            // მაგრამ აგრეთვე მუშაობს user defined კონსტრუქტორი 
            Customer customer2 = new Customer("Perte", "Ivanishvili");
            customer2.PrintCustomer();

            Console.ReadLine();
        }
    }
}
