using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharp.Tricks.Performance
{
  public class StringBuilderAndStringDemo
  {
    /// <summary>
    /// Use StringBuilder for More Efficient String Concatentation
    /// </summary>
    public static void Run()
    {
      int count = 100000;

      Console.WriteLine("Start");

      Console.WriteLine("Init StringBuilder");
      Stopwatch swStringBuilder = new Stopwatch();
      swStringBuilder.Start();
      StringBuilder sb = new StringBuilder("");
      for (int i = 0; i < 50000; i++)
        sb.Append(i.ToString());
      swStringBuilder.Stop();
      Console.WriteLine("StringBuilder: {0}", swStringBuilder.Elapsed);

      Console.WriteLine("Init String");
      Stopwatch swString = new Stopwatch();
      swString.Start();
      string s1 = "";
      for (int i = 0; i < count; i++)
        s1 = s1 + i.ToString();
      swString.Stop();
      Console.WriteLine("String: {0}", swString.Elapsed);

     
      Console.WriteLine("StringBuilder vs String init time: " + swString.ElapsedTicks / swStringBuilder.ElapsedTicks);
    }

  }
}
