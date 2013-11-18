using System;

namespace CSharp.Tricks.GarbageCollection
{
  public class GarbageCollection2Demo
  {
    public static void Run()
    {

      MyClass myClass1 = new MyClass();
      MyClass myClass2 = new MyClass(19);
      myClass1.Dispose(); // myClass1 is explicitly exposed.
      System.GC.Collect();
      System.GC.WaitForPendingFinalizers();


     
    }
  }

  class MyClass : IDisposable
  {
    public MyClass() //default ctor
    {
      this.iNumber = 0;
      System.Console.WriteLine("ctor:MyClass {0}", iNumber);
    }

    public MyClass(Int32 iNumber) // specialized ctor
    {
      this.iNumber = iNumber;
      System.Console.WriteLine("ctor:MyClass {0}", iNumber);
    }

    ~MyClass() // dtor or finalize
    {
      System.Console.WriteLine("dtor:~MyClass {0}", iNumber);
    }

    public void Dispose() // helper finalize function
    {
      // here you can free the resources you allocated explicitly
      System.GC.SuppressFinalize(this);
    }

    private int iNumber;
  }


   
}
