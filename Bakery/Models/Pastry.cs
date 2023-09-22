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

    public int PriceTotalP()
    {
      int totP = (this.PastryNum * 2) - ((this.PastryNum / 4)*2);
      return totP;
    }
  }
}  