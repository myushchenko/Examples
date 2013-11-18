using System;
using System.Threading;

namespace CSharp.Tricks.GarbageCollection.Details
{
  public class SimpleDisposeRelease
  {
    public static void Run()
    {
      var timer = new Timer(Method, "Hello", 0, 200);

      Console.ReadLine();
      timer.Dispose();
    }

    static void Method(object state)
    {
      Console.WriteLine(state);
      GC.Collect();
    }
  }
}
