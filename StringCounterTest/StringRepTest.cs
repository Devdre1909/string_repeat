using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCounter;

namespace StringCounterTest;

[TestClass]
public class StringRepTest
{
  [TestMethod]
  public void TestRepeatPostive()
  {
    StringRep stringRep = new StringRep("adfresbalios");
    bool expectedCase_a = true;
    bool expectedCase_b = false;
    // Act
    bool actualCase_a = stringRep.isRepeated("a");
    bool actualCase_b = stringRep.isRepeated("i");
    // Assert
    Assert.AreEqual(expectedCase_a, actualCase_a);
    Assert.AreEqual(expectedCase_b, actualCase_b);

  }

  [TestMethod]
  public void TestRepeatNegative()
  {
    StringRep stringRep = new StringRep("dammyi");
    bool expectedCase_a = false;
    bool expectedCase_b = true;
    // Act
    bool actualCase_a = stringRep.isRepeated("m");
    bool actualCase_b = stringRep.isRepeated("i");
    // Assert
    Assert.AreNotEqual(expectedCase_a, actualCase_a);
    Assert.AreNotEqual(expectedCase_b, actualCase_b);

  }

}