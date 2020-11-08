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
            return _id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
