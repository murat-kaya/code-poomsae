using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace FizzBuzzServices.Tests
{
  [TestClass]
  public class FizzBuzzServiceTest
  {
    private readonly FizzBuzzService _service;
    public FizzBuzzServiceTest()
    {

      _service = new FizzBuzzService();
    }

    [TestMethod]
    public void FizzTest()
    {

      Assert.AreEqual("Fizz", _service.WriteFizz(3));
      Assert.AreEqual("Buzz", _service.WriteFizz(5));
      Assert.AreEqual("FizzBuzz", _service.WriteFizz(15));
    }

    [TestMethod]
    public void FizzBuzzArrayTest()
    {
      int[] arr = Enumerable.Range(1, 100).Select(x => x).ToArray();
      
      List<string> list = new List<string>();

      foreach(int number in arr){
         
         list.Add(_service.WriteFizz(number));
      }
    
        File.WriteAllLines(@"..\..\..\TestResults\FizzBuzzOutput.txt", list);
    }
  }
}
