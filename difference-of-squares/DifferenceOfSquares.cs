using System;

public static class Squares
{
    public static int SquareOfSums(int max)
    {
      double total = 0;

      for(int i = 1; i <= max; i++)
      {
        total += (double)i;
      }

      double finalTotal = Math.Pow(total, 2);
      return (int)finalTotal;
    }

    public static int SumOfSquares(int max)
    {
      double total = 0;

      for(int i = 1; i <= max; i++)
      {
        total += Math.Pow(i, 2);
      }

      return (int)total;
    }

    public static int DifferenceOfSquares(int max)
    {
      int difference = SquareOfSums(max) - SumOfSquares(max);
      return difference;
    }
}
