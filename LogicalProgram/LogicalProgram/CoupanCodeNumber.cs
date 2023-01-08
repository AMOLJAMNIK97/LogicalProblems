using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class CoupanCodeNumber
    {
        public void GetCouponNumber()
        {
            Random random = new Random();
            int NUMBER = (random.Next(1, 6));

            int COUPON1 = 185620;
            int COUPON2 = 163467;
            int COUPON3 = 172390;
            int COUPON4 = 128690;
            int COUPON5 = 139870;

            if (NUMBER == 1)
            {
                Console.WriteLine("Your coupon number is :- " + COUPON1);
            }
            else if (NUMBER == 2)
            {
                Console.WriteLine("Your coupon number is :- " + COUPON2);
            }
            else if (NUMBER == 3)
            {
                Console.WriteLine("Your coupon number is :- " + COUPON3);
            }
            else if (NUMBER == 4)
            {
                Console.WriteLine("Your coupon number is :- " + COUPON4);
            }
            else if (NUMBER == 5)
            {
                Console.WriteLine("Your coupon number is :- " + COUPON5);
                Console.ReadLine();
            }
        }
    }
}
