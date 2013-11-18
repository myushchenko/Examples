using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp.Tricks.Collections
{
  public class ArrayListDemo
  {
   
    public static void Run()
    {
      ArrayList list = new ArrayList();
      list.Add("cat");
      list.Add(2);
      list.Add(false);

      foreach (var element in list)
      {
        Console.WriteLine(element);
      }

    }

  }
}
