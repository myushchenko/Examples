using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CSharp.Tricks.Generics
{
  public class LinkedListDemo
  {
    public static void Run()
    {
      Example1();
      Example2();
      Example3();
    }

    public static void Example1()
    {
      Console.WriteLine("Program that uses LinkedList: C#");
      //
      // Create a new linked list object instance.
      //
      LinkedList<string> linked = new LinkedList<string>();
      //
      // Use AddLast method to add elements at the end.
      // Use AddFirst method to add element at the start.
      //
      linked.AddLast("cat");
      linked.AddLast("dog");
      linked.AddLast("man");
      linked.AddFirst("first");
      //
      // Loop through the linked list with the foreach-loop.
      //
      foreach (var item in linked)
      {
        Console.WriteLine(item);
      }
    }
    public static void Example2()
    {
      Console.WriteLine("Problem that loops over LinkedList: C#");
      // Create a new linked list.
      //
      LinkedList<string> linked = new LinkedList<string>();
      //
      // First add three elements to the linked list.
      //
      linked.AddLast("one");
      linked.AddLast("two");
      linked.AddLast("three");
      //
      // Insert a node before the second node (after the first node)
      //
      LinkedListNode<string> node = linked.Find("one");
      linked.AddAfter(node, "inserted");
      //
      // Loop through the linked list.
      //
      foreach (var value in linked)
      {
        Console.WriteLine(value);
      }
    }

    public static void Example3()
    {
      const int _max = 100000;

      Console.WriteLine("Problem that loops over LinkedList: C#");
      var list = new List<string>();
      var link = new LinkedList<string>();
      // ... Add elements.
      for (int i = 0; i < 1000; i++)
      {
        list.Add("OK");
        link.AddLast("OK");
      }

      var s1 = Stopwatch.StartNew();
      for (int i = 0; i < _max; i++)
      {
        foreach (string v in list)
        {
          if (v.Length != 2)
          {
            throw new Exception();
          }
        }
      }
      s1.Stop();
      var s2 = Stopwatch.StartNew();
      for (int i = 0; i < _max; i++)
      {
        foreach (string v in link)
        {
          if (v.Length != 2)
          {
            throw new Exception();
          }
        }
      }
      s2.Stop();
      Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) /
          _max).ToString("0.00 ns"));
      Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) /
          _max).ToString("0.00 ns"));
    }
  }

}
