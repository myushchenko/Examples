using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CSharp.Tricks.Performance
{
  public class DictionaryVsListDemo
  {
    private const int Count = 1000000;

    public static void Run()
    {
      var list = new List<int>();
      var dictionary = new Dictionary<int, int>();


      Console.WriteLine("***Test 1***");
      var sList = Stopwatch.StartNew();


      for (int i = 0; i < Count; i++)
      {
        list.Add(i);
      }

      sList.Stop();
      Console.WriteLine("List init time: " + sList.Elapsed);


      var sDictionary = Stopwatch.StartNew();
      for (int i = 0; i < Count; i++)
      {
        dictionary.Add(i, i);
      }
      sDictionary.Stop();
      Console.WriteLine("Dictionary init time: " + sDictionary.Elapsed);

      Console.WriteLine("Dictionary vs List init time: " + sDictionary.ElapsedTicks / sList.ElapsedTicks);


      Console.WriteLine("\n***Test 2***\n");

      // 1. Get random number.
      int number = new Random().Next(1, Count);

      // 2. See if it exists in Dictionary.
      sDictionary = Stopwatch.StartNew();
      if (dictionary.ContainsKey(number))
      {
        sDictionary.Stop();
        Console.WriteLine("Dictionary search time: " + sDictionary.Elapsed);
      }

      // 3. See if it exists in List.
      sList = Stopwatch.StartNew();
      list.Contains(number);
      sList.Stop();
      Console.WriteLine("List search time: " + sList.Elapsed);
      Console.WriteLine("List vs Dictionary(Contains) search time: " + sList.ElapsedTicks / sDictionary.ElapsedTicks);
     sList.Reset();
      sList.Start();
      foreach (int l in list)
      {
        if (l == number)
        {
          sList.Stop();
          Console.WriteLine("List search time: " + sList.Elapsed);
          break;
        }
      }


      Console.WriteLine("List vs Dictionary(foreach) search time: " + sList.ElapsedTicks / sDictionary.ElapsedTicks);
    }

  }
}
