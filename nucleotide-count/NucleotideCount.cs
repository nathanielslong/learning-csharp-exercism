using System;
using System.Collections.Generic;

public class DNA
{
    public DNA(string sequence)
    {
      foreach (char ch in sequence)
      {
        NucleotideCounts[ch]++;
      }
    }

    public Dictionary<char, int> NucleotideCounts = new Dictionary<char, int>
    {
      { 'A', 0 },
      { 'C', 0 },
      { 'G', 0 },
      { 'T', 0 }
    };

    public int Count(char nucleotide)
    {
      if (!NucleotideCounts.ContainsKey(nucleotide))
      {
        throw new InvalidNucleotideException();
      }
      return NucleotideCounts[nucleotide];
    }
}

public class InvalidNucleotideException : Exception
{
  public InvalidNucleotideException()
  {
  }
}
