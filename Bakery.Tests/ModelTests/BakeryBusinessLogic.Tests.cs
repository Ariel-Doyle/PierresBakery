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

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void DeterminePastryPrice_ReturnPriceOfOnePastry_Int()
    {
      int priceOfPastry = 2;
      Assert.AreEqual(priceOfPastry, Pastry.DeterminePastryPrice(1));
    }   
    [TestMethod]
    public void DeterminePastryPrice_ReturnPriceOfFourPastry_Int()
    {
      int priceOfPastry = 6;
      Assert.AreEqual(priceOfPastry, Pastry.DeterminePastryPrice(4));
    } 
  }

  [TestClass]
  public class CartTests
  {
    [TestMethod]
    public void CartConstructor_CreateInstanceOfCart_Cart()
    {
      Cart newCart = new Cart();
      Assert.AreEqual(typeof(Cart), newCart.GetType());
    }
    [TestMethod]
    public void GetCartLoafValues_ReturnCartLoafValues_Int()
    {
      int expectedLoaves = 10;
      Cart newCart = new Cart{LoavesPurchased = expectedLoaves};
      Assert.AreEqual(expectedLoaves, newCart.LoavesPurchased);      
    }
    [TestMethod]
    public void GetCartPastryValues_ReturnCartPastryValues_Int()
    {
      int expectedPastry = 5;
      Cart newCart = new Cart{PastriesPurchased = expectedPastry};
      Assert.AreEqual(expectedPastry, newCart.PastriesPurchased);
    }
    [TestMethod]
    public void UpdateValues_ReturnUpdatedValues_Int()
    {
      int initialLoaves = 10;
      int initialPastry = 5;
      Cart newCart = new Cart{LoavesPurchased = initialLoaves, PastriesPurchased = initialPastry};

      int updateLoaves = 20;
      int updatePastry = 10;
      newCart.LoavesPurchased = updateLoaves;
      newCart.PastriesPurchased = updatePastry;

      Assert.AreEqual(updateLoaves, newCart.LoavesPurchased);
      Assert.AreEqual(updatePastry, newCart.PastriesPurchased);
    }
  }
}