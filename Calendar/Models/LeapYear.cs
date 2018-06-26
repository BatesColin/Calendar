using System;
using System.Collections.Generic;

namespace Calendar
{
  public class LeapYear
  {

    public bool IsLeapYear(int year)
    {
      return year % 4 == 0;
    }
    public bool IsDivisibleByHundred(int year)
    {
      return year % 100 != 0;
    }
    public bool IsDivisibleByFourHundred(int year)
    {
      return year % 400 == 0;
    }
  }


  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Enter a year.");
      int enteredYear = int.Parse(Console.ReadLine());
      LeapYear newLeapYear = new LeapYear();

      if(newLeapYear.IsLeapYear(enteredYear))
      {
        if (newLeapYear.IsDivisibleByHundred(enteredYear))
        {
          Console.WriteLine("This is a Leap Year.");
        }
        else
        {
          if (newLeapYear.IsDivisibleByFourHundred(enteredYear))
          {
            Console.WriteLine("This is a Leap Year.");
          }
          else
          {
            Console.WriteLine("This is not a Leap Year.");
          }
        }
      }
      else
      {
        Console.WriteLine("This is not a Leap Year.");
      }
    }
  }
}
