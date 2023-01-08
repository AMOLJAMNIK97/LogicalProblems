using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose the Option");
            Console.WriteLine("1.Fibonacci Series");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.CheckFibonacciSeries();
                    break;
                
            }
        }

    }
}