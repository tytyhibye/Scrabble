using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Model;

namespace Scrabble.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {

    }
    [TestMethod]
    public void UserInput_IsUserInputAString_True()
    {
      // Arrange
      Logic testOne = new Logic();
      // Act
      Logic.GetInput("string");
      // Assert
      Assert.AreEqual(typeof(string), Logic.Input.GetType());
    }

    [TestMethod]
    public void Dictionary_CreateKey_DictionaryValues()
    {
      // arrange
      Logic testTwo = new Logic();
      // act
      Logic.CreateKey();
      //assert
      Assert.AreEqual(Logic.valueOne, Logic.tileValue[1]);
    }
  }
}