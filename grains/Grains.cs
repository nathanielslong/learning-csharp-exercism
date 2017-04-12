using System;

public static class Grains
{
    public static ulong Square(int n)
    {
      double amount = Math.Pow(2, n - 1);
      return (ulong)amount;
    }

    public static ulong Total()
    {
      ulong total = 0;

      for(int i = 0; i < 64; i++)
      {
        total += Square(i + 1);
      }

      return total;
    }
}
