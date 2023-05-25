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
            Console.WriteLine("Welcome to the monthlypaments for EMI UC4");

            Console.WriteLine("Please enter the Principal amount");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the how many year you want");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Rate of interest");
            double R = Convert.ToDouble(Console.ReadLine());


            double n = 12 * Y;
            double r = R / (12 * 100);

            double payment = (p * r) / (1 - Math.Pow(1 + r, -n));

            Console.WriteLine("The total Monthly Payment {0}", payment);




        }




}   }
