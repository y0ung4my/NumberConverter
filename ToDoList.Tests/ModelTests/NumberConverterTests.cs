using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumberToWords
  {
    // Test methods go here
    [TestMethod]
    public void NumberConverterConstructor_CreatesInstanceOfNumberConverter_1()
    {
      string number = "1";
      NumberConverter newNumberToConvert = new NumberConverter(number);
      Assert.AreEqual(typeof(NumberConverter), newNumberToConvert.GetType());
    }
    [TestMethod]
    public void ConvertNumberToWord_ConvertSingleDigit_1()
    {
      string number = "1";
      NumberConverter newNumberToConvert = new NumberConverter(number);
      Assert.AreEqual("one", newNumberToConvert.ConvertNumberToWord());
    } 
    [TestMethod]
    public void ConvertNumberToWord_ConvertTeens_10()
    {
      string number = "10";
      NumberConverter newNumberToConvert = new NumberConverter(number);
      Assert.AreEqual("ten", newNumberToConvert.ConvertNumberToWord());
    } 
    [TestMethod]
    public void ConvertNumberToWord_ConvertTens_20()
    {
      string number = "20";
      NumberConverter newNumberToConvert = new NumberConverter(number);
      Assert.AreEqual("twenty", newNumberToConvert.ConvertNumberToWord());
      // Console.WriteLine(ConvertNumberToWord());
    } 
  }
}