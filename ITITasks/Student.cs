using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
   public class Student:Person
    {
     
        double grade;
        string state = "";
        public void SetGrade(double _grade)

        {

            if ((_grade < 100) && (_grade > 0))
                grade = _grade;

            if ((_grade < 65.00) && (_grade > 50.00))
            {
                state = " Passed ";
            }
            else if ((_grade > 65.00) && (_grade < 75.00))
            {
                state = "Good";
            }
            else if ((_grade > 75.00) && (_grade < 85.00))
            {
                state = "Very Good";
            }
            else if ((_grade >= 85.00) && (_grade < 100.00))
            {
                state = "Excellent";
            }
            else
            {
                state = "fail";
            }

        }
        public double  GetGrade()
        {

            return grade;
        }

        public  Student()
        {
            Console.WriteLine("this is a constructor of Student class with no param");
        }

        public Student(int _id):base(_id)
        {
            Console.WriteLine("this is a constructor of Student class with one param");
        }

        public Student(int _id, string _name) : base(_id,_name)
        {
            Console.WriteLine("this is a constructor of Student class with two param");
        }

        public Student( int _id, string _name, int _age) : base(_id,_name,_age)
        {
            Console.WriteLine("this is a constructor of Student class with three param");
        }


        public override void Print()
        {

            base.Print(); // to exec methods in parent class and child class 
            Console.WriteLine($"Hello {Name} , Your ID is {Id} , Your age {Age} is and  Your Grade is {grade} so you are {state}");

        }



    }
}
