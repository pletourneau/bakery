using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryNum {get; set;}
    public Pastry(int userInputPastry)
    {
      PastryNum = userInputPastry;
    }
  }
}  