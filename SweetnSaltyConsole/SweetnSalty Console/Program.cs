using System;

namespace SweetnSalty_Console
{
  class Program
  {
    static void Main(string[] args)
    {
      SweetnSalty();
    }

    /// <summary>
    /// Method that prints numbers 1 - 1000 in groups of 10 per line with one space separating each number.
    /// - When the number is a multiple of three, “sweet” is printed instead of the number to the console.
    /// - If the number is a multiple of five,“salty” is printed (instead of the number) to the console.
    /// - For numbers which are multiples of three and five, “sweet’nSalty” is printed to the console (instead of the number).
    /// - After the numbers have all been printed, the total number of  sweet’s,salty’s, and sweet’nSalty’s are printed on 3 seperate lines
    /// </summary>
    static public void SweetnSalty()
    {
      int sweetCount = 0; //tracks the total number of Sweet
      int saltyCount = 0; //tracks the total number of Salty
      int snsCount = 0; //tracks the total number of sweet'nSalty

      //loop to repeat the code encapsulated 1000 times
      for (int i = 1; i <= 1000; i++)
      {

        //determines if 10 numbers have passed and it's time to start a new line 
        //keep this at the top to control when the program puts numbers on a new line
        if (i % 10 == 0)
        {
          Console.WriteLine(i + " ");
        }
        //determines when a number is a multiple of 3 and 5 for example 15 and writes sweet'nSalty
        //increments sns counter;
        //this one must be first in the if statements
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.Write("sweet'nSalty ");
          snsCount++;
        }
        //determines if the number is a multiple of 3 
        //increments sweet counter;
        else if (i % 3 == 0)
        {
          Console.Write("sweet ");
          sweetCount++;

        }
        //determines if the number is a multiple of 5
        //increments saltyCounter;
        else if (i % 5 == 0)
        {
          Console.Write("salty ");
          saltyCount++;
        }
        //if the number fits none of the conditions then just print the number
        else
        {
          Console.Write(i + " ");
        }
      }//EOLoop

      Console.WriteLine($"sweet's: {sweetCount}");
      Console.WriteLine($"salty's: {saltyCount}");
      Console.WriteLine($"sweet'nSalty's: {snsCount}");
    }//EoM
  }//EOc
}//EoN
