using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Stopwatch
    {
        public void stopwatch()
        {

            Console.WriteLine("Enter number of laps:- ");
            int laps = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Watch will start from 0.00");

            double start = 0;
            double elapsedTime;
            double totalElapsedTime = 0;
            int i = 1;

            while (i <= laps)
            {
                Console.WriteLine("Enter the end time:- ");
                double end = Convert.ToInt32(Console.ReadLine());
                if (end < start)
                {
                    Console.WriteLine("New end time should be greater than previous end time.");
                }
                else
                {
                    elapsedTime = end - start;
                    totalElapsedTime = totalElapsedTime + elapsedTime;
                    Console.WriteLine("Elapsed Time is:- " + elapsedTime);
                    start = end;
                    i++;
                }

            }
            Console.WriteLine("Elapsed time between End and Start is:- " + totalElapsedTime);
        }
    }
}
