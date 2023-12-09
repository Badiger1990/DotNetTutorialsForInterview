using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTutorials
{
    public class SwappingProgram
    {
        public string SwapNumbers(int num1, int num2)
        {
            int num3 = 0;
            //if(num1 != null && num2 != null)
            //{
                num3 = num1;
                num1 = num2;
                num2 = num3;
            //}
            Console.WriteLine("num1 is: "+num1 +"and num2 is"+num2);
            return $"{num1}, {num2}";
        }
    }
}
