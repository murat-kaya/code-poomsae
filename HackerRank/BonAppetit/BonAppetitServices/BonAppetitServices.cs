using System;
using System.Collections.Generic;
using System.Linq;

namespace BonAppetitServices
{
  public class BonAppetitServices
  {
    public string BonAppetit(List<int> bill, int k, int b)
    {
      decimal sumOfBill = bill.Sum(); 
      decimal sumOfBeShared = sumOfBill - bill[k]; 
      decimal sumOfAnnaShare = (sumOfBill - bill[k]) / 2;

      if (Math.Round(sumOfAnnaShare) != b)
      {
        return (Math.Abs(b - sumOfAnnaShare)).ToString();
      }
      else
        return "Bon Appetit";
    }
  }
}
