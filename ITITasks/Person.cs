using System;
using System.Collections.Generic;
using System.Text;
namespace task_1
{
   public class Person
    {
        protected int id;
        protected string name;
        protected int age;

        public int Id { get => id; set => id = value;}
        public string Name { get => name; set => name = value;}
        public int Age { get => age; set => age = value;}

        public Person()
        {
            Console.WriteLine("this default constructor of Person Class");
        }

        public Person(int _id)
        {
            id = _id;
            Console.WriteLine("this constructor of one param in Person Class");
        }

        public Person(int _id,string _name)
        {
            id = _id;
            name = _name;
            Console.WriteLine("this constructor of Two param in Person Class");
        }
        public Person(int _id, string _name,int _age)
        {
            id = _id;
            name = _name;
            age = _age;
            Console.WriteLine("this constructor of Three param in Person Class");
        }

        public virtual void Print()
        {
            Console.WriteLine($"Id: {Id} , Name : {Name}, Age : {Age} "); 
        }


    }
}
