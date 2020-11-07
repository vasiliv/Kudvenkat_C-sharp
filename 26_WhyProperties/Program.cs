using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// class student, id ar unda ikos 0-ze naklebi, name ar unda ikos nullis toli

namespace _26_WhyProperties
{
    class Student
    {
        private int _id;
        private string _name;

        public void SetId(int id)
        {
            if (id < 0)
            {
                throw new Exception("less than zero");
            }
            else
            {
                this._id = id;
            }
        }
        public int GetId()
        {
            return this._id;
        }
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("null");
            }
            else
            {
                this._name = name;
            }
        }
        public string GetName()
        {
            return this._name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //student.SetId(-10);
            student.SetId(10);
            Console.WriteLine("Student id = {0}", student.GetId());
            //student.SetName(null);
            student.SetName("Vaso");
            Console.WriteLine("Student name = {0}", student.GetName());
            Console.ReadLine();
        }
    }
}
