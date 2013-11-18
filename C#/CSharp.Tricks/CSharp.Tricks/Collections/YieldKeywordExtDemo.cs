using System;
using System.Collections.Generic;

namespace CSharp.Tricks.Collections
{
  public class YieldKeywordExtDemo
  {
    
    public static void Run()
    {
      ShowResult("Default result: ", CountTo100Twice());

    }
    static void ShowResult(string title, IEnumerable<int> values)
    {
      Console.WriteLine("\n\n" + title);
      foreach (int i in values)
      {
        Console.Write(i + " ");
      }
    }

    static IEnumerable<int> CountTo100Twice()
    {
      foreach (int i in CountTo100()) yield return i;
      foreach (int i in CountTo100()) yield return i;
    }

    static IEnumerable<int> CountTo100()
    {
      for (var i = 1; i <= 100; i++)
      {
        yield return i;
      }
    }
  }
}
