using DotNetTutorials.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTutorials
{
    internal class NumberPrograms : INumberPrograms
    {
        // 256
        // 2*2*2=8, 5*5*5=125, 6*6*6=216 not.
        /// <summary>
        /// Function to find input number is armstrong number or not
        /// </summary>
        /// <param name="number"></param>
        /// <returns>True if it is armstrong number else false</returns>
        public bool IsArmstrongNumber(int number)
        {
            int tempNumber = 0, sum = 0, rem = 0;
            tempNumber = number;

            Console.WriteLine($"Input number is: {number}");
            while (number > 0)
            {
                rem = number % 10;
                Console.WriteLine($"\nreminder is: {rem}");
                sum = sum + (rem * rem * rem);
                Console.WriteLine($"Sum is : {sum}");
                number = number / 10;
                Console.WriteLine($"number is: {number}");
            }

            return tempNumber == sum ? true : false;
        }
    }
}
