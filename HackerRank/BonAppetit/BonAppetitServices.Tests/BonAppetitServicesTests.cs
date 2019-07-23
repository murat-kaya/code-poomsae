using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BonAppetitServices.Tests
{
  [TestClass]
  public class BonAppetitServicesTests
  {

    private BonAppetitServices _services;
    public BonAppetitServicesTests()
    {
      _services = new BonAppetitServices();
    }
    
    [TestMethod]
    public void BonAppetitTest()
    {

      List<int> arr = new List<int>() { 3, 10, 2, 9 };

      Assert.AreEqual("5", _services.BonAppetit(arr, 1, 12));

    }
  }
}
