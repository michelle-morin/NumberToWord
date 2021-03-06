using System;
using System.Collections.Generic;

namespace NTW.Models
{
  public class Number
  {
    public static Dictionary<char, string> ones { get; } = new Dictionary<char, string>() { 
      {'0', "zero"}, 
      {'1', "one"}, 
      {'2', "two"}, 
      {'3', "three"}, 
      {'4', "four"}, 
      {'5', "five"}, 
      {'6', "six"}, 
      {'7', "seven"}, 
      {'8', "eight"}, 
      {'9', "nine"} 
    };
    public static Dictionary<string, string> teens { get; } = new Dictionary<string, string>() {
      {"10", "ten"}, 
      {"11", "eleven"}, 
      {"12", "twelve"}, 
      {"13", "thirteen"}, 
      {"14", "fourteen"}, 
      {"15", "fifteen"}, 
      {"16", "sixteen"}, 
      {"17", "seventeen"}, 
      {"18", "eighteen"}, 
      {"19", "nineteen"} 
    };
    public static Dictionary<char, string> tens { get; } = new Dictionary<char, string>() { 
      {'2', "twenty"}, 
      {'3', "thirty"}, 
      {'4', "forty"}, 
      {'5', "fifty"}, 
      {'6', "sixty"}, 
      {'7', "seventy"}, 
      {'8', "eighty"}, 
      {'9', "ninety"} 
    };

    public static string ConvertNumber(string stringInputNumber)
    {
      char[] numberArray = stringInputNumber.ToCharArray();
      try
      {
        int number = int.Parse(stringInputNumber);
        string convertedNumber = "";
        if (stringInputNumber.Length <= 2)
        {
          convertedNumber = ConvertTwoDigits(stringInputNumber);
        }
        else if (stringInputNumber.Length == 3)
        {
          convertedNumber = Number.ConvertThreeDigits(stringInputNumber, numberArray);
        }
        else if (stringInputNumber.Length == 4)
        {
          convertedNumber = Number.ConvertFourDigits(stringInputNumber, numberArray);
        }
        else if (stringInputNumber.Length == 5)
        {
          convertedNumber = Number.ConvertFiveDigits(stringInputNumber, numberArray);
        }
        else if (stringInputNumber.Length == 6)
        {
          convertedNumber = Number.ConvertSixDigits(stringInputNumber, numberArray);
        }
        else if (stringInputNumber.Length == 7)
        {
          convertedNumber = Number.ConvertSevenDigits(stringInputNumber, numberArray);
        }
        else if (stringInputNumber.Length == 8)
        {
          convertedNumber = Number.ConvertEightDigits(stringInputNumber, numberArray);
        }
        else if (stringInputNumber.Length == 9)
        {
          convertedNumber = Number.ConvertNineDigits(stringInputNumber, numberArray);
        }
        else if (stringInputNumber.Length == 10)
        {
          convertedNumber = Number.ConvertTenDigits(stringInputNumber, numberArray);
        } 
        else
        {
          convertedNumber = "That's too large to convert at this time! Please enter a number <= 1 trillion.";
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

    public static string ConvertTenDigits(string stringInputNumber, char[] numberArray)
    {
      string convertedNumber = null;
      if (numberArray[0] == '0')
      {
        char[] newNumArray = { numberArray[1], numberArray[2], numberArray[3], numberArray[4], numberArray[5], numberArray[6], numberArray[7], numberArray[8], numberArray[9] };
        string newNumber = new String(newNumArray);
        convertedNumber = Number.ConvertNineDigits(newNumber, newNumArray);
      }
      else
      {
        char firstDigit = numberArray[0];
        char[] secondThreeArray = { numberArray[1], numberArray[2], numberArray[3] };
        string stringSecondThree = new String(secondThreeArray);
        char[] thirdThreeArray = { numberArray[4], numberArray[5], numberArray[6] };
        string stringThirdThree = new String(thirdThreeArray);
        char[] lastThreeArray = { numberArray[7], numberArray[8], numberArray[9] };
        string stringLastThree = new String(lastThreeArray);
        string trillions = ones[firstDigit];
        string millions = Number.ConvertThreeDigits(stringSecondThree, secondThreeArray);
        if (millions == "" || millions == null)
        {
          millions = null;
        }
        else
        {
          millions = millions + " million ";
        }
        string thousands = Number.ConvertThreeDigits(stringThirdThree, thirdThreeArray);
        if (thousands == "" || thousands == null)
        {
          thousands = null;
        }
        else
        {
          thousands = thousands + " thousand ";
        }
        string hundreds = Number.ConvertThreeDigits(stringLastThree, lastThreeArray);
        convertedNumber = trillions + " trillion " + millions + thousands + hundreds;
      }
      return convertedNumber;
    }

    public static string ConvertNineDigits(string stringInputNumber, char[] numberArray)
    {
      string convertedNumber = null;
      if (numberArray[0] == '0')
      {
        char[] newNumArray = { numberArray[1], numberArray[2], numberArray[3], numberArray[4], numberArray[5], numberArray[6], numberArray[7], numberArray[8] };
        string newNumber = new String(newNumArray);
        convertedNumber = Number.ConvertEightDigits(newNumber, newNumArray);
      }
      else
      {
        char[] firstThreeArray = { numberArray[0], numberArray[1], numberArray[2] };
        string stringFirstThree = new String(firstThreeArray);
        char[] secondThreeArray = { numberArray[3], numberArray[4], numberArray[5] };
        string stringSecondThree = new String(secondThreeArray);
        char[] lastThreeArray = { numberArray[6], numberArray[7], numberArray[8] };
        string stringLastThree = new String(lastThreeArray);
        string firstNumber = Number.ConvertThreeDigits(stringFirstThree, firstThreeArray);
        string secondNumber = Number.ConvertThreeDigits(stringSecondThree, secondThreeArray);
        if (secondNumber == "" || secondNumber == null)
        {
          secondNumber = null;
        }
        else
        {
          secondNumber = secondNumber + " thousand ";
        }
        string thirdNumber = Number.ConvertThreeDigits(stringLastThree, lastThreeArray);
        convertedNumber = firstNumber + " million " + secondNumber + thirdNumber;
      }
      return convertedNumber;
    }

    public static string ConvertEightDigits(string stringInputNumber, char[] numberArray)
    {
      string convertedNumber = null;
      if (numberArray[0] == '0')
      {
        char[] newNumArray = { numberArray[1], numberArray[2], numberArray[3], numberArray[4], numberArray[5], numberArray[6], numberArray[7] };
        string newNumber = new String(newNumArray);
        convertedNumber = Number.ConvertSevenDigits(newNumber, newNumArray);
      }
      else
      {
        char[] firstTwoArray = { numberArray[0], numberArray[1] };
        string stringFirstTwo = new String(firstTwoArray);
        char[] secondThreeArray = { numberArray[2], numberArray[3], numberArray[4] };
        string stringSecondThree = new String(secondThreeArray);
        char[] lastThreeArray = { numberArray[5], numberArray[6], numberArray[7] };
        string stringLastThree = new String(lastThreeArray);
        string firstNumber = Number.ConvertTwoDigits(stringFirstTwo);
        string secondNumber = Number.ConvertThreeDigits(stringSecondThree, secondThreeArray);
        if (secondNumber == "" || secondNumber == null)
        {
          secondNumber = null;
        }
        else
        {
          secondNumber = secondNumber + " thousand ";
        }
        string thirdNumber = Number.ConvertThreeDigits(stringLastThree, lastThreeArray);
        convertedNumber = firstNumber + " million " + secondNumber + thirdNumber;
      }
      return convertedNumber;
    }

    public static string ConvertSevenDigits(string stringInputNumber, char[] numberArray)
    {
      string convertedNumber = null;
      if (numberArray[0] == '0')
      {
        char[] newNumArray = { numberArray[1], numberArray[2], numberArray[3], numberArray[4], numberArray[5], numberArray[6] };
        string newNumber = new String(newNumArray);
        convertedNumber = Number.ConvertSixDigits(newNumber, newNumArray);
      }
      else
      {
        char firstDigit = numberArray[0];
        char[] secondThreeArray = { numberArray[1], numberArray[2], numberArray[3] };
        string stringSecondThree = new String(secondThreeArray);
        char[] lastThreeArray = { numberArray[4], numberArray[5], numberArray[6] };
        string stringLastThree = new String(lastThreeArray);
        string firstNumber = ones[firstDigit];
        string secondNumber = Number.ConvertThreeDigits(stringSecondThree, secondThreeArray);
        if (secondNumber == "" || secondNumber == null)
        {
          secondNumber = null;
        }
        else
        {
          secondNumber = secondNumber + " thousand ";
        }
        string thirdNumber = Number.ConvertThreeDigits(stringLastThree, lastThreeArray);
        convertedNumber = firstNumber + " million " + secondNumber + thirdNumber;
      }
      return convertedNumber;
    }

    public static string ConvertSixDigits(string stringInputNumber, char[] numberArray)
    {
      string convertedNumber = null;
      if (numberArray[0] == '0')
      {
        char[] newNumArray = { numberArray[1], numberArray[2], numberArray[3], numberArray[4], numberArray[5] };
        string newNumber = new String(newNumArray);
        convertedNumber = Number.ConvertFiveDigits(newNumber, newNumArray);
      }
      else
      {
        char[] firstThree = { numberArray[0], numberArray[1], numberArray[2] };
        string hundredThousands = new String(firstThree);
        char[] lastThreeArray = { numberArray[3], numberArray[4], numberArray[5] };
        string stringLastThree = new String(lastThreeArray);
        string hundredThousandsPlace = Number.ConvertThreeDigits(hundredThousands, firstThree);
        string remainder = Number.ConvertThreeDigits(stringLastThree, lastThreeArray);
        convertedNumber = hundredThousandsPlace + " thousand " + remainder;
      }
      return convertedNumber;
    }

    public static string ConvertFiveDigits(string stringInputNumber, char[] numberArray)
    {
      string convertedNumber = null;
      if (numberArray[0] == '0')
      {
        char[] newNumArray = { numberArray[1], numberArray[2], numberArray[3], numberArray[4] };
        string newNumber = new String(newNumArray);
        convertedNumber = Number.ConvertFourDigits(newNumber, newNumArray);
      }
      else
      {
        char[] firstTwo = { numberArray[0], numberArray[1]};
        string firstDigits = new String(firstTwo);
        char[] lastThreeArray = { numberArray[2], numberArray[3], numberArray[4] };
        string stringLastThree = new String(lastThreeArray);
        string tenThousandsPlace = teens[firstDigits];
        string hundreds = Number.ConvertThreeDigits(stringLastThree, lastThreeArray);
        convertedNumber = tenThousandsPlace + " thousand " + hundreds;
      }
      return convertedNumber;
    }

    public static string ConvertFourDigits(string stringInputNumber, char[] numberArray)
    {
      char firstDigit = numberArray[0];
      char[] otherDigits = { numberArray[1], numberArray[2], numberArray[3] };
      string remainingDigits = new String(otherDigits);
      string wordRemainder = Number.ConvertThreeDigits(remainingDigits, otherDigits);
      if (numberArray[0] != '0')
      {
        string thousandsPlace = ones[firstDigit];
        string wordNum = thousandsPlace + " thousand " + wordRemainder;
        return wordNum;
      }
      else if (numberArray[0] == '0')
      {
        return wordRemainder;
      }
      else
      {
        return null;
      }
    }

    public static string ConvertThreeDigits(string stringInputNumber, char[] numberArray)
    {
      char firstDigit = numberArray[0];
      char[] otherDigits = { numberArray[1], numberArray[2] };
      string remainingDigits = new String(otherDigits);
      string wordRemainder = Number.ConvertTwoDigits(remainingDigits);
      if (numberArray[0] != '0')
      {
        string hundredsPlace = ones[firstDigit];
        string wordNum = hundredsPlace + " hundred " + wordRemainder;
        return wordNum;
      }
      else if (numberArray[0] == '0')
      {
        return wordRemainder;
      }
      else
      {
        return null;
      }
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