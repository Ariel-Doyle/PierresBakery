using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryStoreFront.Models;

namespace BakeryStoreFront.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }    
    [TestMethod]
    public void DetermineBreadPrice_ReturnPriceOfOneLoaf_Int()
    {
      int priceOfBread = 5;
      Assert.AreEqual(priceOfBread, Bread.DetermineBreadPrice(1));
    }
    [TestMethod]
    public void DetermineBreadPrice_ReturnPriceOfThreeLoaves_Int()
    {
      int priceOfBread = 10;
      Assert.AreEqual(priceOfBread, Bread.DetermineBreadPrice(3));
    }
  }

  // [TestClass]
  // public class PastryTests
  // {
  //   [TestMethod]
  //   public void //display list of selected pastry
  //   {

  //   }
  // }

}