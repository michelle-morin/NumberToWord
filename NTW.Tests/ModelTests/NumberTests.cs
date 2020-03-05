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

  }
}