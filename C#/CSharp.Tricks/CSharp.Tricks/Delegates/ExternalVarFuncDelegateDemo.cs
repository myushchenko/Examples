using System;

namespace CSharp.Tricks.Delegates
{
  public class ExternalVarFuncDelegateDemo
  {
    public static void Run()
    {
      Sample1();
      Sample2();
      Sample3();
    }
    static void Sample1()
    {
      Console.WriteLine("Sample 1");

      int factor = 2;
      Func<int, int> multiplier = n => n * factor;
      factor = 10;
      Console.WriteLine(multiplier(3));
    }

    static void Sample2()
    {
      Console.WriteLine("Sample 2");

      int seed = 0;
      Func<int> natural = () => seed++;
      Console.WriteLine(natural());
      Console.WriteLine(natural());
      Console.WriteLine(seed);
    }

    static void Sample3()
    {
      Console.WriteLine("Sample 3");

      Func<int> natural = Natural();
      Console.WriteLine(natural());
      Console.WriteLine(natural());
    }

    static Func<int> Natural()
    {
      int seed = 0;
      return () => seed++;//Returns the circuit
    } 
  }
}
