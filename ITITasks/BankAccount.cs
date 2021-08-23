using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
  public class BankAccount
    {
        int id;
        string name;
        int balance;

        //make empty constructor method 
            public BankAccount()
            { 
            }

            //make  constructor method
            public BankAccount(int id , string name ,int balance)
            {
                this.Id = id;
                this.name = name;
                this.balance = balance;
            }

           //encapsulation for id 
            public int Id { set => id = value; get => id; }

           //long way for encapsulation through methods 
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
            else if ((balance > 100) && (b <= 100))
                Console.WriteLine("Sorry! You Can't Withdrawl less than 1000");
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
