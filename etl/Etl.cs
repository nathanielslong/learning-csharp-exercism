using System;
using System.Collections.Generic;

public static class ETL
{
    public static IDictionary<string, int> Transform(IDictionary<int, IList<string>> old)
    {
      var transformed = new Dictionary<string, int>();
      foreach (KeyValuePair<int, IList<string>> entry in old)
      {
        foreach(var piece in entry.Value)
        {
          transformed.Add(piece.ToLower(), entry.Key);
        }
      }
      return transformed;
    }
}
