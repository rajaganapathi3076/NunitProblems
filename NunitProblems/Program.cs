using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitProblems
{
    
    
 

    public static class MathUtils
    {
       
        public static void Main(string[] args)
        {
            string answer;
            string result;
            Console.WriteLine("Welcome to the Decimal to Binnary function UC6");
            Console.WriteLine("Please enter the number");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "  ";

            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result=Convert.ToString(num) +result;
            Console.WriteLine("Binary: {0}", result);


            
        }
    }





}   
