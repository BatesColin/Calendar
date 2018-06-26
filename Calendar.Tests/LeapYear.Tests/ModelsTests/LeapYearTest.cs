using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.Tests
{
  [TestClass]
  public class LeapYearTest
  {
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
    }
    [TestMethod]
    public void IsLeapYear_DivisibleByHundred_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsDivisibleByHundred(2100));
    }
    [TestMethod]
    public void IsLeapYear_DivisibleByFourHundred_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsDivisibleByFourHundred(1600));
    }
  }
}
