using System;
using System.Linq;
using System.Collections.Generic;

namespace MigratoryBirdsServices
{
  public class MigratoryBirdsServices
  {
    public int GroupOfBirds(List<int> numbers)
    {
      var group = numbers.GroupBy(i => i).Select(g => new
      {
        Type = g.Key,
        Count = g.Count()
      }).OrderByDescending(c => c.Count).ThenBy(c => c.Type).Select(p => p.Type).FirstOrDefault();

      return (Convert.ToInt32(group));
    }
  }
}