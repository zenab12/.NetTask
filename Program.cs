using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                        Console.WriteLine("please enter your name");
                        String userName =  Console.ReadLine();
                        Console.WriteLine("Hello {0} in our program . enjoy! \n", userName);

                        //task1 

                        int[] arr = new int [4];
                        int sum = 0;
                        int maxVal =0;
                        int minVal =0;

                        Console.WriteLine("Please enter 4 numbers as array to get the summation of it and minVal and maxVal ");

                        for(int i =0; i < arr.Length;i++)
                        {               
                             arr [i] = int.Parse(Console.ReadLine());
                             sum += arr[i];

                        }
                        Array.Sort(arr);
                        foreach (int i in arr)
                        {
                            maxVal = arr[arr.Length - 1];
                            minVal = arr[0];
                        }

                        Console.WriteLine("max: " + maxVal + " and minVal: " + minVal + " and sum : " + sum + "\n");

                      

                        //another solutuon 

                        /*
                        for(int i =0; i < arr.Length;i++)
                        {               
                             arr [i] = int.Parse(Console.ReadLine());
                             maxVal = arr.Max();//worked due to linq class of sys
                             minVal = arr.Min();
                             sum += arr[i];
                        }
                        Console.WriteLine("max: " + maxVal + " and minVal: " + minVal + " and sum : " + sum);
                       */


                        //task2

                        Console.WriteLine("enter the 7 digit to get the largest space between samilar values");

                        int[] arr2 = new int[7];
                        int firstInd = 0;
                        int lastInd = 0;
                        int spaceBetweenIndexes = 0;
                        int samilarElement = 0;
                        int max = 0;
                        string result = "";

                        for (int i = 0; i < 7; i++)
                        {
                            arr2[i] = int.Parse(Console.ReadLine());
                            int j = 0;
                            while(j< 7)
                            {
                                if (arr2[i] == arr2[j])
                                {
                                    firstInd = Array.IndexOf(arr2, arr2[i]);
                                    lastInd = Array.LastIndexOf(arr2, arr2[j]);
                                    spaceBetweenIndexes = lastInd - firstInd;
                                    samilarElement = arr2[i];
                                }
                                if (spaceBetweenIndexes > max)
                                {
                                    max = spaceBetweenIndexes;
                                    result = $"firstIndex of element  {samilarElement} : { firstInd} and lastIndex of element  {samilarElement} : { lastInd} and the space between them :{max}";
                                }else if(max == 0)
                                {
                                    result = "not similar";
                                }
                                j++;
                            }
                        }
                        Console.WriteLine(result + "\n");
             



                        //task3

                        Console.WriteLine("enter any digit to get the numbers of ones inside it ");

                        int num = int.Parse(Console.ReadLine());
                        ArrayList onesArr = new ArrayList() { };
                        int count = 0;
                        int flag =  0;

                        for (int i = 1; i <= num ; i++)
                        {
                            string [] newstr = Convert.ToString(i).Split("");
                            for (int j = 0; j < newstr.Length; j++)
                            {
                               //Console.WriteLine(newstr[j]);
                                 if (newstr[j].Contains("1"))
                                {
                                    onesArr.Add(newstr[j]);
                                    if((newstr.Contains("10") || newstr.Contains("100")) && (num > 10)) flag = 1; 
                                }
                            }
                        }

                        count = onesArr.Count;
                        Console.WriteLine(count + flag);
                        Console.WriteLine();


                        //task 4

                        Console.WriteLine("enter num to get the reversed num");

                        int numToReverse = int.Parse(Console.ReadLine());
                        string strNum = Convert.ToString(numToReverse);
                        List <char> reversedCharArr = new List <char> ();

                        for(var i = strNum.Length - 1; i >= 0;i--)
                        {
                            reversedCharArr.Add(strNum[i]);
                        }

                        string reversedNum = string.Join("", reversedCharArr);
                        Console.WriteLine($"The Reversed Num is : {reversedNum}");
          

           
                        Console.ReadKey();
                    }

        

    }
            
}
