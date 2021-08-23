using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class Instructor:Person
    {
        float salary;

        public Instructor()
        {
            Console.WriteLine("this is a constructor of Instructor class with no param");
        }

        public Instructor(int _id) : base(_id)
        {
            Console.WriteLine("this is a constructor of Instructor class with one param");
        }

        public Instructor(int _id, string _name) : base(_id, _name)
        {
            Console.WriteLine("this is a constructor of Instructor class with two param");
        }

        public Instructor(int _id, string _name, int _age) : base(_id, _name, _age)
        {
            Console.WriteLine("this is a constructor of Instructor class with three param");
        }

        public Instructor(int _id, string _name, int _age,float _salary) : base(_id, _name, _age)
        {
            salary = _salary;
            Console.WriteLine("this is a constructor of Instructor class with four param");
        }


        public float Salary { private get => salary; set => salary = value;}

        public override void Print()
        {

            base.Print(); // to exec methods in parent class and child class 
            Console.WriteLine($"Hello {Name} , Your ID is {Id} , Your age {Age} is and  Your Salary is {salary}");

        }



    }
}
