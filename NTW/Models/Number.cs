using System;
using System.Collections.Generic;

namespace NTW.Models
{
  public class Number
  {
    public static Dictionary<char, string> ones { get; } = new Dictionary<char, string>() { {'0', "zero"}, {'1', "one"}, {'2', "two"}, {'3', "three"}, {'4', "four"}, {'5', "five"}, {'6', "six"}, {'7', "seven"}, {'8', "eight"}, {'9', "nine"} };
    public static Dictionary<string, string> teens { get; } = new Dictionary<string, string>() { {"10", "ten"}, {"11", "eleven"}, {"12", "twelve"}, {"13", "thirteen"}, {"14", "fourteen"}, {"15", "fifteen"}, {"16", "sixteen"}, {"17", "seventeen"}, {"18", "eighteen"}, {"19", "nineteen"} };
    public static Dictionary<char, string> tens { get; } = new Dictionary<char, string>() { {'2', "twenty"}, {'3', "thirty"}, {'4', "forty"}, {'5', "fifty"}, {'6', "sixty"}, {'7', "seventy"}, {'8', "eighty"}, {'9', "ninety"} };

    public static string ConvertNumber(string stringInputNumber)
    {
      try
      {
        int number = int.Parse(stringInputNumber);
        char[] numberArray = stringInputNumber.ToCharArray();
        string convertedNumber = "";
        if (stringInputNumber.Length <= 2)
        {
          convertedNumber = ConvertTwoDigits(stringInputNumber);
        }
        else if (stringInputNumber.Length == 3 && numberArray[0] != '0')
        {
          convertedNumber = Number.ConvertThreeDigits(stringInputNumber, numberArray);
        }
        else
        {
          return "other";
        }
        return convertedNumber; 
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

    public static string ConvertThreeDigits(string stringInputNumber, char[] numberArray)
    {
      char firstDigit = numberArray[0];
      string hundredsPlace = ones[firstDigit];
      char[] otherDigits = { numberArray[1], numberArray[2] };
      string remainingDigits = new String(otherDigits);
      string wordRemainder = Number.ConvertTwoDigits(remainingDigits);
      string wordNum = hundredsPlace + " hundred " + wordRemainder;
      return wordNum;
    }

    public static string ConvertTwoDigits(string stringInputNumber)
    {
      char[] numberArray = stringInputNumber.ToCharArray();
      string wordNumber = "";
      if (stringInputNumber.Length == 1)
      {
        char inputNum = numberArray[0];
        wordNumber = ones[inputNum];
      }
      else if (stringInputNumber.Length == 2 && numberArray[0] == '1')
      {
        wordNumber = teens[stringInputNumber];
      }
      else if (stringInputNumber.Length == 2 && numberArray[0] != '0' && numberArray[1] == '0')
      {
        char firstDigit = numberArray[0];
        wordNumber = tens[firstDigit];
      }
      else if (stringInputNumber.Length == 2 && numberArray[0] != '0')
      {
        char firstDigit = numberArray[0];
        char secondDigit = numberArray[1];
        wordNumber = tens[firstDigit] + " " + ones[secondDigit];
      }
      else if (stringInputNumber.Length == 2 && numberArray[0] == '0' && numberArray[1] != '0')
      {
        char secondDigit = numberArray[1];
        wordNumber = ones[secondDigit];
      }
      else if (stringInputNumber.Length == 2 && numberArray[0] == '0' && numberArray[1] == '0')
      {
        wordNumber = null;
      }
      return wordNumber; 
    }
  }
}