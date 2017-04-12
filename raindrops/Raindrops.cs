using System;
using System.Collections.Generic;

public static class Raindrops
{
  public static string Convert(int number)
  {
    List<string> answer = new List<string>();

    if(number % 3 == 0)
    {
      answer.Add("Pling");
    }

    if(number % 5 == 0)
    {
      answer.Add("Plang");
    }

    if(number % 7 == 0)
    {
      answer.Add("Plong");
    }

    if(number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
    {
      answer.Add(number + "");
    }
    var result = String.Join("", answer.ToArray());
    return result;
  }
}
