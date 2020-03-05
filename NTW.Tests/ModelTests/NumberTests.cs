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
      string wordNum = Number.ConvertNumber("0");
      Assert.AreEqual("zero", wordNum);
    }
  }
}