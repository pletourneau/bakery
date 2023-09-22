using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int LoafNum {get; set;}

     public Bread(int numOfLoaf)
    {
      LoafNum = numOfLoaf;
    }
  }
}