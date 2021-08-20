using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    class ComplexNum
    {

        int realNum;
        double imaginaryNum;


        public void SetRealNum(int _realNum)
        {
               realNum = _realNum;
        }
        public int GetRealNum()
        {
            return realNum;
        }

        public void SetImaginaryNum(double _imaginaryNum)
        {
            imaginaryNum = _imaginaryNum;
        }
        public double GetImaginaryNum()
        {
            return imaginaryNum;
        }


        public void PrintNum()
        {
            string operation = "";
            if (imaginaryNum > 0)
                operation = " + ";

         Console.WriteLine($"the complex num is : {realNum}{operation}{imaginaryNum} i");
        }

    }
}
