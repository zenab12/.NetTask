using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class BankAccount
    {
        int id;
        string name;
        int balance;

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
            if(_name.Length > 3)
               name = _name;
        }
        public string GetName()
        {
            return name;
        }

        public void Deposite(int _balance)
        {
            if((_balance < 1000000) && (_balance > 50))
               balance += _balance;

            else
                Console.WriteLine("this is not enough to deposite in your account ");
        }
      
        public int Withdrawl(int b)
        {
            if ((b < balance) && (b > 100))
                balance -= b;
            else
                Console.WriteLine("your account not contain this amount of money");
          return balance;

        }
        public void Print()
        {
            Console.WriteLine($"Hello {name} , Your ID is {id} and Your Balance in Your Bank ACCount is {balance}");

        }


    }


  
}
