using System;

namespace FizzBuzzServices
{
  public class FizzBuzzService
  {
    public int FakeServiceTest()
    {
      throw new NotImplementedException("Warming up...");
    }

    public string WriteFizz(int number)
    {

      if (number % 15 == 0)
      {
        return "FizzBuzz";
      }
      else if (number % 3 == 0)
      {
        return "Fizz";
      }
      else if (number % 5 == 0)
      {
        return "Buzz";
      }
      else
      {
        return number.ToString();
      }
    }
  }
}
