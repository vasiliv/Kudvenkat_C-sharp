using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Properties
{
    class Student
    {
        private int _id;
        private string _name;

        public int Id
        {
            set { 
                if (value < 0)
                {
                    throw new Exception("less than zero");
                }
                else
                {
                    this._id = value;
                }
            }
            get
            {
                return this._id;
            }
        }
        public string Name
        {
            set { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("null");
                }
                else
                {
                    this._name = value;
                }
            }
            get
            {
                return this._name;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //student.Id = -10;
            student.Id = 10;
            Console.WriteLine("Student id = {0}", student.Id);
            //student.Name = null;
            student.Name = "Vaso";
            Console.WriteLine("Student name = {0}", student.Name);
            Console.ReadLine();
        }
    }
}
