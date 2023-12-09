using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTutorials
{
    internal class FibonacciSeries
    {
        public void PrintFibonacciSeries(int number) 
        {
            //0,1,1,2,3,5,8,13
            int num1=0,num2=1, sum=0;
            Console.Write($"{num1},{num2}");
            for (int i = 0; i < number; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                Console.Write($",{sum}");
            }
        }

        public void Main()
        {
            RecorsiveFibonacciSeries(0, 1, 1, 8);
        }

        private void RecorsiveFibonacciSeries(int firstNumber,int secondNumber,int counter,
            int number)
        {
            Console.Write(firstNumber+",");
            if(counter < number)
                RecorsiveFibonacciSeries(secondNumber,firstNumber+secondNumber,counter+1,number);
        }

    }
}
