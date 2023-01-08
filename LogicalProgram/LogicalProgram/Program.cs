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
            Console.WriteLine("1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse Number\n5.Coupan Number");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.CheckFibonacciSeries();
                    break;
                case 2:
                    PerfectNumber perfect = new PerfectNumber();
                    perfect.perfectnumber();
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.CheckPrime();
                    break;
                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.CreatReverseNumber();
                    break;
                case 5:
                    CoupanCodeNumber coupan = new CoupanCodeNumber();
                    coupan.GetCouponNumber();
                    break;

                
            }
        }

    }
}