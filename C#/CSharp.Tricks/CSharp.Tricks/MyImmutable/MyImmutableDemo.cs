using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Tricks.MyImmutable
{
  

  public class MyImmutableDemo
  {
    public static void Run()
    {
      int x = 5;
      Console.WriteLine("My Immutable Type");
      Console.WriteLine("Init value: " + x);
      Console.WriteLine("<------------------------>");
      MyImmutableType m = new MyImmutableType(x);
      TriesToBeBadFunc(m);
      Console.WriteLine("Result==" + m.x);
      if (m.x == x)
        Console.WriteLine("It's immutable type!");

      MyMutableType m1 = new MyMutableType(x);
      BadFunc(m1);
      Console.WriteLine("Result==" + m1.x);
      if (m1.x == x)
        Console.WriteLine("It's immutable type!");
    }

    static double BadFunc(MyMutableType t)
    {
      t.Square();
      return t.x;
    }

    static double TriesToBeBadFunc(MyImmutableType t)
    {
      t = t.Square();
      return t.x;
    }

  }

  class MyMutableType
  {
    public double x;
    public MyMutableType(double _x) { x = _x; }
    public MyMutableType Square() { return new MyMutableType(x=x * x); }
  }

  class MyImmutableType
  {
    public readonly double x;
    public MyImmutableType(double _x) { x = _x; }
    public MyImmutableType Square() { return new MyImmutableType(x * x); }
  }
}
