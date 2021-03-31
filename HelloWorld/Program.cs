using System;
namespace Revature.Week1.HelloWorld
{
   class Program
   {
      static void Main()
      {
         Console.WriteLine("enter a name: ");

         var input = Console.ReadLine();

         //stout to print your name
         Console.WriteLine($"Hello {input}");//string interpolation, template string, condenses into a single slot
                                             //  Console.WriteLine("Hello " + input);//standard, slightly slower, takes 3 slots on a stack 
      }
      private void UiPath()
      {

      }
   }
}
