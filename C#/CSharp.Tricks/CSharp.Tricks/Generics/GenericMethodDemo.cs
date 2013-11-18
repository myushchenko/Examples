using System;

namespace CSharp.Tricks.Generics
{
  public class GenericMethodDemo
  {
    public static void Run()
    {

      MyGeneric g = new MyGeneric();
      g.GenericMethod(100);
      g.GenericMethod("Sourav");
      Console.ReadLine();
    }

  }

  class MyGeneric
  {
    public void GenericMethod<T>(T obj)
    {
      Console.WriteLine("Argument type :" + obj.GetType() );
      Console.WriteLine("Argument Value : " + obj.ToString());
      Console.WriteLine("*******************************");
    }
  }
}
