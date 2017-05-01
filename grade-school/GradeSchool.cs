using System;
using System.Collections.Generic;
using System.Linq;

public class School
{
  public Dictionary<int, List<string>> roster = new Dictionary<int, List<string>>();

  public void Add(string student, int grade)
  {
    if (!roster.ContainsKey(grade))
    {
      roster[grade] = new List<string>();
    }
    roster[grade].Add(student);
    roster[grade].Sort();
  }

  public IEnumerable<string> Roster()
  {
    var flattenRoster = roster.SelectMany(x => x.Value);
    return flattenRoster;
  }

  public IEnumerable<string> Grade(int grade)
  {
    if (!roster.ContainsKey(grade))
    {
      return new List<string>();
    }
    return roster[grade].ToArray();
  }
}
