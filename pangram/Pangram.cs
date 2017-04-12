using System;

public static class Pangram
{
  public static bool IsPangram(string input)
  {
    char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    input = input.ToLower();
    char[] inputArray = input.ToCharArray();

    for(int i = 0; i < inputArray.Length; i++)
    {
      int index = Array.IndexOf(alpha, inputArray[i]);

      if(index != -1)
      {
        alpha[index] = '\0';
      }
    }

    foreach (char c in alpha)
    {
      if(!c.Equals('\0'))
      {
        return false;
      }
    }
    return true;
  }
}
