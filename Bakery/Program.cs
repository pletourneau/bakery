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

      try
      {
        int userInputBread = int.Parse(breadString);
        int userInputPastry = int.Parse(pastryString);
        CalcPrice(userInputBread, userInputPastry);
      }
      catch
      {
        Console.WriteLine("Please enter a valid integer. I can only calculate up to about 2 billion dollars, so if you more than that please call instead.");
        Main();
      }
    }
    static void CalcPrice(int userInputBread, int userInputPastry)
    {
      Pastry pastryNum = new Pastry (userInputPastry);
      Bread breadNum = new Bread (userInputBread);

      int total = breadNum.PriceTotal() + pastryNum.PriceTotalP();
      Console.WriteLine($"That will be {total} dollars you uncultured swine");
    
    }
  }
}