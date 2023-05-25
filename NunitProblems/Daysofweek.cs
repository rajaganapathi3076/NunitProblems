using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitProblems
{
    internal class Daysofweek
    {
        public static void Getyear()
        {
            Console.WriteLine("Welcome to the days of weekUC2");

            Console.WriteLine("Enter the year");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the days");
            int d = Convert.ToInt32(Console.ReadLine());

            int y1 = 0;
            int x = 0;
            int m1 = 0;
            int d1 = 0;

             y1 = y - (14 - m) / 2;
             x = y1 + y1 / 4 - y1 / 100 + y1 / 400;
             m1 = m + 12 * ((14 - m) / 12) - 2;
             d1=(d+x+ (31* m1)/12) % 7;


            Console.WriteLine("The year is {0}" ,y1);
            Console.WriteLine("The month is {1}", m1);
            Console.WriteLine("The day is{2}", d1);
        }





    }   
    
}
