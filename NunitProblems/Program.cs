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
           
            Console.WriteLine("Welcome to the Nunit problems");
            int[] notes = new int[] { 1000, 500, 100, 50, 20,10, 5, 2, 1 };
            int amount = 0;
            Console.WriteLine("Enter the amount:");
            amount = Convert.ToInt32(Console.ReadLine());
            int totalNotes = 0;
            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    totalNotes += amount / notes[i];
                    Console.WriteLine(notes[i] + " Rs Notes : " + amount / notes[i]);
                    amount %= notes[i];
                }
            }
            Console.WriteLine("Total Number of Notes : " + totalNotes);
        }


    }

            
        
    
}
