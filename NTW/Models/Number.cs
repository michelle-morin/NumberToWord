using System;
using System.Collections.Generic;

namespace NTW.Models
{
  public class Number
  {
    public static Dictionary<string, string> ones { get; } = new Dictionary<string, string>() { {"0", "zero"}, {"1", "one"}, {"2", "two"}, {"3", "three"}, {"4", "four"}, {"5", "five"}, {"6", "six"}, {"7", "seven"}, {"8", "eight"}, {"9", "nine"} };
    public static Dictionary<string, string> teens { get; } = new Dictionary<string, string>() { {"10", "ten"}, {"11", "eleven"}, {"12", "twelve"}, {"13", "thirteen"}, {"14", "fourteen"}, {"15", "fifteen"}, {"16", "sixteen"}, {"17", "seventeen"}, {"18", "eighteen"}, {"19", "nineteen"} };
    public static Dictionary<string, string> tens { get; } = new Dictionary<string, string>() { {"2", "twenty"}, {"3", "thirty"}, {"4", "forty"}, {"5", "fifty"}, {"6", "sixty"}, {"7", "seventy"}, {"8", "eighty"}, {"9", "ninety"} };

    public static string ConvertNumber(string stringInputNumber)
    {
      try
      {
        int number = int.Parse(stringInputNumber);
        if (stringInputNumber.Length == 1)
        {
          return ones[stringInputNumber];
        }
        else
        {
          return "other";
        }
      }
      catch (FormatException)
      {
        return "invalid input";
      }
      catch (Exception exception)
      {
        return exception.Message;
      }
    }
  }
}