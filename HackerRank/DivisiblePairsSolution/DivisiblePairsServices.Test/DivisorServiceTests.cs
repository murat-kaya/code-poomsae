using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DivisiblePairsServices.Test
{
  [TestClass]
  public class DivisorServiceTests
  {
    int[] numbers = { 1, 3, 2, 6, 1, 2 };
    private readonly DivisorServices _services;

    public DivisorServiceTests()
    {
      _services = new DivisorServices();
    }

    [TestMethod]
    public void IsDivisible()
    {
      Assert.AreEqual(5, _services.CountDivisibleNumbers(numbers, 3));
    }
  }
}
