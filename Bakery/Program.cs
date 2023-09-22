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
        Console.WriteLine("Would you like to price out another order? Type yes to start another order");

        string answer = Console.ReadLine();

        if (answer.ToLower() == "yes") 
        {
          Main();
        }
        else
        {
          Console.WriteLine("Au revoir mon ami");
        }
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

      int brTot = breadNum.PriceTotal();
      int paTot = pastryNum.PriceTotalP();
      int total =  brTot + paTot;

      Console.WriteLine($"Let's see, it will cost {brTot} for the bread and {paTot} for the pastry so....");
      Console.WriteLine($"That will be {total} dollars s'il vous plaît");
    }
  }
}