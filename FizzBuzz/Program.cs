using System;

namespace FizzBuzz
{
   // allow the user to give us upperBound, lowerBound (think validate)
   // allow the user to set condition for multiple 7, 11
   // count from 0 to 100, and print eaach number per line
   // if number is multiple of 3, print fizz
   // if number is multiple of 5, print buzz
   // if number is multiple of both, print fizzbuzz
   class FizzProgram
   {
      static void Main(string[] args)
      {
         FizzProgram pgm = new FizzProgram();
         pgm.countNumbers(0, 100);

      }
      private void CheckFizzBuzz(int a, int div1, int div2)
      {
         if (a != 0)
         {
            if (a % div1 == 0 && a % div2 == 0)
               WriteToConsole("fizzbuzz");
            else
            {
               if (a % div1 == 0)
                  WriteToConsole("fizz");
               if (a % div2 == 0)
                  WriteToConsole("buzz");
            }

         }
      }
      private void countNumbers(int start, int end, int inc = 1)
      {
         for (var i = start; i <= end; i += inc)
         {
            WriteToConsole(i);
         }
      }

      private void WriteToConsole()
      {
         if (a == 0 && b != null)
            Console.WriteLine(b);
         else
            Console.WriteLine(a);

      }
   }
}
