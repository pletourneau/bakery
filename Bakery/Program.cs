using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to your Bakery!");
      Console.WriteLine("Each bread loaf is $5, and every third loaf is free");
      Console.WriteLine("Each pastry is $2, and every fourth loaf is free");
      Console.WriteLine("How many pastries would you like?");
      string pastryString = Console.ReadLine();
      Console.WriteLine("How many loaves of bread would you like?");
      string breadString = Console.ReadLine();

      int userInputBread = int.Parse(breadString);
      int userInputPastry = int.Parse(pastryString);
      Console.WriteLine($"did you want {userInputBread} loaf/loaves?");
    }
  }
}