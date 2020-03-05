using System;
using System.Collections.Generic;

namespace NTW.Models
{
  public class Number
  {
    public static string ConvertNumber(string inputNumber)
    {
      if (inputNumber == "0")
      {
        return "zero";
      }
      else
      {
        char[] numberArray = inputNumber.ToCharArray();
        return "number";
      }
    }
  }
}