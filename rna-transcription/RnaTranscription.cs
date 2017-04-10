using System;

public static class Complement
{
  public static string OfDna(string nucleotide)
  {
    char[] nuclearArray = nucleotide.ToCharArray();

    for(int i = 0; i < nuclearArray.Length; i++)
    {
      if(nuclearArray[i].Equals('C'))
      {
        nuclearArray[i] = 'G';
      }
      else if(nuclearArray[i].Equals('G'))
      {
        nuclearArray[i] = 'C';
      }
      else if(nuclearArray[i].Equals('A'))
      {
        nuclearArray[i] = 'U';
      }
      else
      {
        nuclearArray[i] = 'A';
      }
    }

    string final = new string(nuclearArray);
    return final;
  }
}
