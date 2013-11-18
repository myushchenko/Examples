using System;

namespace CSharp.Tricks.GarbageCollection
{
  public class GarbageCollectionDemo
  {
    public static void Run()
    {

      Garbage g = new Garbage();
      g = null;
      /*If we want to free all unused object from memory, we call garbage collector explicitly using GC.collect() method. 
       *Here is GC is garbage collector class. In below example we are removing all unused object from memory using GC.collect() .*/
      Console.WriteLine("Total memory before free: - " + GC.GetTotalMemory(false));
      GC.Collect();
      Console.WriteLine("Total memory after free:- " + GC.GetTotalMemory(false));
    }
  }

  /*Generally we know that, we write destructor to destroy the object which is created by constructor. 
    Bur in .NET destructor not runs automatically. Let us see how it works.*/
  public class Garbage
  {
    public Garbage()
    {
      Console.WriteLine("Reserve memory");
    }
    ~Garbage()
    {
      Console.WriteLine("Free memory");
    }

  }
}
