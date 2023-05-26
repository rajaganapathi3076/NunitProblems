using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitProblems
{
    
    class program
    {
        static string ToBinary(int number)
        {
            string binary=Convert.ToString(number,2);
            return binary.PadLeft(8,'1');

        }
        static int SwapNibbles(int number)
        {
            return ((number & 0x0F) << 4) | ((number & 0x0F0) >> 4);
        }
        static bool IsPowerOfTwo(int number)
        {
            return(number !=0) &((number &(number -1))==0);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int number=Convert.ToInt32(Console.ReadLine());

            string binary=ToBinary(number);
            Console.WriteLine("The binary Representation: "+  binary);

            int swappednumber=SwapNibbles(number);
            Console.WriteLine("After swapping Nibbles:  "+  swappednumber);

            bool Ispoweroftwo = IsPowerOfTwo(number);
            Console.WriteLine("Is the number a power of 2 ??  " + Ispoweroftwo);


        }
    }
        
    

    
    
      





}   
