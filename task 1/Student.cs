using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class Student
    {
        int id;
        int age;
        double grade;
        string name;
        string state = "";


        public void SetId(int _id)
        {
            id = _id;
        }
        public int GetId()
        {
            return id;
        }

        public void SetName(string _name)
        {
            if (_name.Length >= 2)
                name = _name;
        }
        public string GetName()
        {
            return name;
        }


        public void SetAge(int _age)
        {
            age = _age;
        }
        public int  GetAge()
        {
            return age;
        }



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


        public void PrintInfo()
        {
            Console.WriteLine($"Hello {name} , Your ID is {id} , Your age {age} is and  Your Grade is {grade} so you are {state}");

        }



    }
}
