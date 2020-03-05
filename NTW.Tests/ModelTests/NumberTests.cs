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

  }
}