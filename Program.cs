using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTutorials
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\nHello welcome to Dot net tutorials!!");
            Console.WriteLine("Enter your choice");
            Console.WriteLine($"1.Swapping program\n" +
                $"2.Armstrong number\n" +
                $"3.Print Fibonacci series\n" +
                $"4.Numbers using LINQ" +
                $"0.Exit application");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1.Swapping program");
                    SwappingProgram sp = new SwappingProgram();
                    sp.SwapNumbers(0, 19);
                    Main();
                    break;
                case 2:
                    Console.WriteLine("2.Armstrong number");
                    NumberPrograms np = new NumberPrograms();
                    Console.WriteLine("Enter a number to check Armstrong number or not");
                    int input = Convert.ToInt32(Console.ReadLine());
                    bool result = np.IsArmstrongNumber(input);
                    Console.WriteLine($"result is : {result}");
                    if (input != 0)
                        Main();
                    break;
                case 3:
                    Console.WriteLine($"3. Print Fibonacci series" +
                        $"\nEnter number:");
                    FibonacciSeries fs = new FibonacciSeries();
                    //fs.PrintFibonacciSeries(Convert.ToInt32(Console.ReadLine()));
                    fs.Main();
                    Main();
                    break;
                case 4:
                    Console.WriteLine("4. Numbers using LINQ");
                    PowerOfLINQ pl = new PowerOfLINQ();
                    pl.PlayOnNumbersLINQ();
                    break;
                default:
                    Console.WriteLine("Closing your window..");
                    Environment.Exit(1);
                    break;
            }

            Console.ReadKey();
        }
    }
}
