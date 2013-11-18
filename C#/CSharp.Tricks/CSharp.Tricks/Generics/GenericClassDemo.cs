using System;

namespace CSharp.Tricks.Generics
{
  public class GenericClassDemo
  {
    public static void Run()
    {

      MyGeneric<int> A = new MyGeneric<int>(100);
      Console.WriteLine("Type of A:- " + A.GetType());
      int a = A.GetObject();
      Console.WriteLine("Value of A:- " + a);
 
    }

  }

  class MyGeneric<T>
  {
    T obj;
    public MyGeneric(T Ob)
    {
      obj = Ob;
    }
    public T GetObject()
    {
      return obj;
    }
    public void DisplayType()
    {
      Console.WriteLine("Current object type is" + obj.GetType());
    }
  }
}
