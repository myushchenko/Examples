using System;

namespace CSharp.Tricks.Delegates
{
  public class GenericDelegateDemo
  {
    public delegate T Transformer<T>(T arg);

    public static void Run()
    {
      int[] values = { 1, 2, 3 };
      Util.Transform(values, Square);// затрагиваем Square 
      foreach (int i in values)
        Console.Write(i + "");// 149 
    }

    static int Square(int x)
    {
      return x * x;
    } 
  }

  public partial class Util
  {
    public static void Transform<T>(T[] values, GenericDelegateDemo.Transformer<T> t)
    {
      for (int i = 0; i < values.Length; i++)
        values[i] = t(values[i]);
    }
  } 
}
