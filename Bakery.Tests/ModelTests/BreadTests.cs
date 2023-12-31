using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PriceTotal_FindsTotalPrice_Int()
    {
      //arrange
      int userInputBread = 2;
      int expPrice = 10;
      //act
      Bread newBread = new Bread(userInputBread);
      int actualPrice = newBread.PriceTotal();
      //assert
      Assert.AreEqual(expPrice, actualPrice);
    }

    [TestMethod]
    public void PriceTotal_FindsTotalPriceWithDiscount_Int()
    {
      //arrange
      int userInputBread = 4;
      int expPrice = 15;
      //act
      Bread newBread = new Bread(userInputBread);
      int actualPrice = newBread.PriceTotal();
      //assert
      Assert.AreEqual(expPrice, actualPrice);
    }
  }
}
