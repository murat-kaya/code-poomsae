using System;

namespace DayOfTheProgrammerServices
{
  public class DayOfTheProgrammerServices
  {
    public string FindDayOfProgrammer(int year)
    {

    // from 1700 to 1917 is julian so mod (4) is lap year then feb is 29
    // from 1918 fo 2700 is gregor so mod(4) and not mod(100) or mod(400) is lap then feb is 29 
    //everything else feb is 28...

      if (year == 1918)
      {
        return "26.09.1918";
      }
      else if ( (year <= 1917 && year % 4 == 0) || ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)))
      {
        return "12.09."+year;
      }
      else
      {
        return "13.09."+year;
      }
    }
  }
}
