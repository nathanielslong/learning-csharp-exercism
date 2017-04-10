using System;

public static class Gigasecond
{
    public static DateTime Date(DateTime birthDate)
    {
      DateTime finalDate = birthDate.AddSeconds(1000000000);
      return finalDate;
    }

}
