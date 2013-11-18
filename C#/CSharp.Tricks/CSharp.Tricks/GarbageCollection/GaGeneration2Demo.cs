using System;

namespace CSharp.Tricks.GarbageCollection
{
  public class GaGeneration2Demo
  {
    public static void Run()
    {
      //Genearte scope here
      Garbage garbageClass = new Garbage();
      Garbage garbageClass2 = new Garbage();
      Console.WriteLine("garbageClass is Created:- " + GC.GetGeneration(garbageClass));
      Console.WriteLine("garbageClass2 is Created:- " + GC.GetGeneration(garbageClass2));

      GC.Collect();
      Console.WriteLine("garbageClass is promoted To:- " + GC.GetGeneration(garbageClass));
      Console.WriteLine("garbageClass2 is promoted To:- " + GC.GetGeneration(garbageClass2));
      garbageClass = null;
      garbageClass2 = null;

      Garbage garbageClass3 = new Garbage();
      Console.WriteLine("garbageClass3 is Created:- " + GC.GetGeneration(garbageClass3));
      garbageClass3 = null;

      GC.Collect(1);
    }
  }

 
}
