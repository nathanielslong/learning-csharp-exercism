using System;
using System.Text.RegularExpressions;

public static class Bob
{
  public static string Hey(string statement)
  {
    if(IsAllUpper(statement) && Regex.IsMatch(statement, @"^(?=.*[a-zA-Z]).+$"))
    {
      return "Whoa, chill out!";
    }
    else if(statement.ToLower().IndexOf('?') != -1)
    {
      int questionIndex = statement.ToLower().IndexOf('?');
      int statementLength = statement.Length;
      bool isWhiteSpace = true;

      for(int i = questionIndex + 1; i < statementLength; i++)
      {
        if(!Char.IsWhiteSpace(statement[i]))
        {
          isWhiteSpace = false;
          break;
        }
      }

      if(isWhiteSpace)
      {
        return "Sure.";
      }
      else
      {
        return "Whatever.";
      }
    }
    else if(String.IsNullOrWhiteSpace(statement))
    {
      return "Fine. Be that way!";
    }
    else
    {
      return "Whatever.";
    }
  }

  public static bool IsAllUpper(string input)
  {
    for(int i = 0; i < input.Length; i++)
    {
      if(Char.IsLetter(input[i]) && !Char.IsUpper(input[i]))
      {
        return false;
      }
    }
    return true;
  }
}
