using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.Clear();
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Each bread loaf is $5"); 
      Console.WriteLine("--buy two, get one free!");
      Console.WriteLine("Each pastry is $2");
      Console.WriteLine("--buy four, get one free!");
      Console.WriteLine("-------------------------");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("How many pastries for you?");
      string pastryString = Console.ReadLine();
      Console.WriteLine("How many loaves of bread for you?");
      string breadString = Console.ReadLine();

      try
      {
        int userInputBread = int.Parse(breadString);
        int userInputPastry = int.Parse(pastryString);
        CalcPrice(userInputBread, userInputPastry);
        Console.WriteLine("Would you like to price out another order? Type yes to start another order");
        

        string answer = Console.ReadLine();

        if (answer.ToLower() == "yes" || answer.ToLower() == "y") 
        {
          Console.Clear();
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
      Console.Clear();
      Console.WriteLine("---------------------------------------------");
      Console.WriteLine($"Let's see, {userInputBread} loaves of bread will cost {brTot} and {userInputPastry} pastries will cost {paTot} so....");
      Console.WriteLine($"That will be {total} dollars s'il vous plaît");
      Console.WriteLine("---------------------------------------------");
    }
  }
}