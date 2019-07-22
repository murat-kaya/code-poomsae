namespace DivisiblePairsServices
{
  public class DivisorServices
  {
    public int CountDivisibleNumbers(int[] numbers, int divisor)
    {
      int counter = 0;
      for (int i = 0; i < numbers.Length; i++)
      {
        for (int j = i + 1; j < numbers.Length; j++)
        {
          if ((numbers[i] + numbers[j]) % divisor == 0)
          {
            counter++;
          }
        }
      }
      return counter;
    }
  }
}
