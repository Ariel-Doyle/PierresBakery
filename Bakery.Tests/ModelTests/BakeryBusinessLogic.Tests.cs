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