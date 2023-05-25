using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number in Celsius");
            double c = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the number in infaherenheit ");
            double f = Convert.ToDouble(Console.ReadLine());


            double F = (c * 9 / 5) + 32;
            double C = (f - 32) * 5 / 9;
            Console.WriteLine("The temperature of celsius in {0} faherenheit {1}",c,F);
            Console.WriteLine("The temperature of faherenheit in {0} celsius   {1}", f, C);
        }


    }

            
        
    
}
