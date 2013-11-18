using System;
using System.Reflection;

namespace CSharp.Tricks.Reflections
{
  public class ChangePrivateMemeberDemo
  {
    public static void Run()
    {
      var sample = new Sample();
      typeof(Sample).GetField("_x", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(sample, "I change you...");
      Console.Write(sample);

    }
  }

  class Sample
  {
    private string _x = "No change me!";
    public override string ToString()
    {
      return _x;
    }
  }

}
