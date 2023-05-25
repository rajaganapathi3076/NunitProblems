using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitProblems
{
    
    
 

    public static class MathUtils
    {
        public static double Sqrt(double c)
        {
            if (c < 0)
            {
                throw new ArgumentException("Input must be nonnegative.");
            }

            double t = c;
            double epsilon = 1e-15;

            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }

            return t;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number");
            double number=Convert.ToDouble(Console.ReadLine());
            
            double squareRoot = MathUtils.Sqrt(number);
            Console.WriteLine($"Square root of {number} is: {squareRoot}");
        }
    }





}   
