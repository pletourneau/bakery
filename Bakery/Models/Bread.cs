using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int LoafNum {get; set;}

    public Bread(int userInputBread)
    {
      LoafNum = userInputBread;
    }

    public int PriceTotal()
    {
      int tot = (this.LoafNum * 5) - ((this.LoafNum / 3)*5);
      return tot;
    }
  }
}