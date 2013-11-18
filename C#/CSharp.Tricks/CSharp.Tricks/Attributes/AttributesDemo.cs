using System;
using System.Collections.Generic;

namespace CSharp.Tricks.Attributes
{
  public class AttributesDemo
  {
   
    public static void Run()
    {

      AttributesCalculator.Add(10, 15);
    }

  }
  public class AttributesCalculator
  {
    [Obsolete("Use Add(List<int> Numbers) instead")]
    public static int Add(int FirstNumber, int secondNumber)
    {
      return FirstNumber + secondNumber;
    }
    public static int Add(List<int> Numbers)
    {
      int Sum = 0;
      foreach (int Number in Numbers)
      {
        Sum = Sum + Number;
      }
      return Sum;
    }
  }
}
