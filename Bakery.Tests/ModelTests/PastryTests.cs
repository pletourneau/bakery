using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void PriceTotalP_FindsTotalPriceP_Int()
    {
      //arrange
      int userInputPastry = 2;
      int expPrice = 4;
      //act
      Pastry newPastry = new Pastry(userInputPastry);
      int actualPrice = newPastry.PriceTotalP();
      //assert
      Assert.AreEqual(expPrice, actualPrice);
    }
  }
}
