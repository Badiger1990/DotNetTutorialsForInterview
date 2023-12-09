using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTutorials
{
    internal class PowerOfLINQ
    {
        public void PlayOnNumbersLINQ()
        {
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            var evenNumbers= from num in numbers
                             where (num % 2 == 0)
                             select num;

            var oddNumbers= from num in numbers
                            where num % 2 == 1
                            select num;

            var sortedNumbers = from num in numbers
                                orderby num descending
                                select num;

            var groupedNumber = from num in numbers
                                group num by num % 2 == 0 into numGroup
                                select new { IsEven = numGroup.Key, Numbers = numGroup };

            Console.WriteLine("\nEven numbers");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num+" ");
            }

            Console.WriteLine("\nOdd numbers");
            foreach (var num in oddNumbers)
            {
                Console.WriteLine(num + " ");
            }

            Console.WriteLine("\nSorted numbers");
            foreach (var num in sortedNumbers)
            {
                Console.WriteLine(num + " ");
            }

            Console.WriteLine("\nGrouped numbers");
            foreach (var numGroup in groupedNumber)
            {
                Console.WriteLine(numGroup.IsEven?"Even number" : "Odd numbers:");
                foreach (var num in numGroup.Numbers)
                {
                    Console.WriteLine(num+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
