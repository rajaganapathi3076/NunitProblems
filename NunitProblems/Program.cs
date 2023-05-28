using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitProblems
{

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Day Of Week problem UC2");
            Console.WriteLine("Please enter the value of year");
            int y= int .Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value of month ");
            int m= int .Parse(Console.ReadLine());
            Console.WriteLine("Please enter the value of day");
            int d= int .Parse(Console.ReadLine());
            int result = 0;

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            result = d0;
            
            switch (result)
            {
                case 0:
                    result = 0;
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    result = 1;
                    Console.WriteLine("Monday");

                    break; 
                case 2:
                    result = 2;
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    result = 3;
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    result = 4;
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    result = 5;
                    Console.WriteLine("Friday");

                    break;
                case 6:
                    result = 6;
                    Console.WriteLine("Saturday");
                    break;

            }

           
            Console.WriteLine("The day of week is {0}", result); 
            


        }
    }
}
