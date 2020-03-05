using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NTW;
using NTW.Models;

namespace NTW.Tests
{
  [TestClass]
  public class NumberTests
  {
    [TestMethod]
    public void ConvertNumber_RejectNonNumericalInputs_Error()
    {
      string wordNum = Number.ConvertNumber("hi");
      Assert.AreEqual("invalid input", wordNum);
    }

    [TestMethod]
    public void ConvertNumber_ReturnsSingleDigitWord_Zero()
    {
      string wordNum = Number.ConvertNumber("0");
      Assert.AreEqual("zero", wordNum);
    }

    [TestMethod]
    public void ConvertNumber_FirstDigitOne_Teen()
    {
      string wordNum = Number.ConvertNumber("12");
      Assert.AreEqual("twelve", wordNum);
    }

    [TestMethod]
    public void ConvertNumber_TwoDigitNumbersEndingInZero_Twenty()
    {
      string wordNum = Number.ConvertNumber("20");
      Assert.AreEqual("twenty", wordNum);
    }

    [TestMethod]
    public void ConvertNumber_TwoDigitNumbers_TwentyTwo()
    {
      string wordNum = Number.ConvertNumber("22");
      Assert.AreEqual("twenty two", wordNum);
    }

    [TestMethod]
    public void ConvertNumber_ThreeDigitNumbers_OneHundredTwenty()
    {
      string wordNum = Number.ConvertNumber("122");
      Assert.AreEqual("one hundred twenty two", wordNum);
    }

    [TestMethod]
    public void ConvertNumber_SkipsZerosInTens_OneHundredThree()
    {
      string wordNum = Number.ConvertNumber("103");
      Assert.AreEqual("one hundred three", wordNum);
    }

    [TestMethod]
    public void ConvertNumber_SkipZeros_ThreeHundred()
    {
      string wordNum = Number.ConvertNumber("300");
      Assert.AreEqual("three hundred ", wordNum);
    }

    [TestMethod]
    public void ConvertNumber_ThousandsDigitNumbers_OneThousandTwoHundred()
    {
      string wordNum = Number.ConvertNumber("1200");
      Assert.AreEqual("one thousand two hundred ", wordNum);
    }

    [TestMethod]
    public void ConvertNumber_TenThousandsNumbers_TenThousandFifty()
    {
      string wordNum = Number.ConvertNumber("10050");
      Assert.AreEqual("ten thousand fifty", wordNum);
    }

    [TestMethod]
    public void ConvertNumber_HundredThousandNumbers_TwoHundredFiftyThousandThree()
    {
      string wordNum = Number.ConvertNumber("250003");
      Assert.AreEqual("two hundred fifty thousand three", wordNum);
    }

    [TestMethod]
    public void ConvertNumber_Millions_MillionsWord()
    {
      string wordNum = Number.ConvertNumber("7502385");
      Assert.AreEqual("seven million five hundred two thousand three hundred eighty five", wordNum);
    }

    [TestMethod]
    public void ConvertNumber_TenMillions_TenMillionsWord()
    {
      string wordNum = Number.ConvertNumber("17502385");
      Assert.AreEqual("seventeen million five hundred two thousand three hundred eighty five", wordNum);
    }

    

  }
}