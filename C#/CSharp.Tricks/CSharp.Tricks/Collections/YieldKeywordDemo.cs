using System;
using System.Collections.Generic;

namespace CSharp.Tricks.Collections
{
  public class YieldKeywordDemo
  {
    static readonly List<int> DemoList = new List<int>();

    public static void Run()
    {
      FillValues(1, 2, 3, 4, 5, 6, 7, 8);

      ShowResult("Default result: ", DemoList);

      ShowResult("Filter Without Yield: ", FilterWithoutYield());

      ShowResult("Filter With Yield: ", FilterWithYield());

      ShowResult("Running Total: ", RunningTotal());

    }

    static void ShowResult(string title, IEnumerable<int> values)
    {
      Console.WriteLine("\n\n" + title);
      foreach (int i in values)
      {
        Console.Write(i + " ");
      }
    }

    static void FillValues(params int[] values)
    {
      foreach (var value in values)
      {
        DemoList.Add(value);
      }
    }

    static IEnumerable<int> FilterWithoutYield()
    {
      var temp = new List<int>();
      foreach (var i in DemoList)
      {
        if (i > 3)
        {
          temp.Add(i);
        }
      }
      return temp;
    }

    static IEnumerable<int> FilterWithYield()
    {
      foreach (int i in DemoList)
      {
        if (i > 3) yield return i;
      }
    }

    static IEnumerable<int> RunningTotal()
    {
      int runningtotal = 0;
      foreach (int i in DemoList)
      {
        runningtotal += i;
        yield return (runningtotal);

      }
    }
  }
}
