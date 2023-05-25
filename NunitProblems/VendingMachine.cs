using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitProblems
{
    internal class VendingMachine
    {

        public static int[] GetNoteCount(int amount, int[] notes)
        {
            Parameter();
            int[] noteCount = new int[notes.Length];
            
            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    noteCount[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }
            return noteCount;
        }



        public static void PrintNoteCount(int[] noteCount, int[] notes)
        {
            Console.WriteLine("Fewest number of notes to be returned:");

            for (int i = 0; i < notes.Length; i++)
            {
                if (noteCount[i] > 0)
                {
                    Console.WriteLine($"{noteCount[i]} notes of {notes[i]}");
                }

            }


        }
        public static void Parameter()
        {
            int[] notes = { 100, 50, 20, 10, 5, 2, 1 };
            int amount = 0;

            Console.Write("Enter the amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            int[] noteCount = GetNoteCount(amount, notes);
            PrintNoteCount(noteCount, notes);
        } 
        public static void Method()
        {
            Console.WriteLine("");
        }
        public static void Method1()
        {
            Console.WriteLine("");
        }

 }  }
   
    
   

