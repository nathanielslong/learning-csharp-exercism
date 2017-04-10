using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int To(IEnumerable<int> multiples, int max)
    {
      int total = 0;

      for(int i = 0; i < max; i++)
      {
        foreach(int multiple in multiples)
        {
          if(i % multiple == 0)
          {
            total += i;
            break;
          }
        }
      }
      return total;
    }
}
