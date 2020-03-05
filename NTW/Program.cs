using System;
using System.Collections.Generic;
using NTW.Models;

namespace NTW
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number in numerical form:");
      string userInput = Console.ReadLine();
      string wordNumber = Number.ConvertNumber(userInput);
      Console.WriteLine($"The written form of {userInput} is {wordNumber}");
    }
  }
}