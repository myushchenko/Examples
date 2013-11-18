using System;

namespace CSharp.Tricks.GarbageCollection
{
  public class GaGenerationDemo
  {
    public static void Run()
    {
      //gets the maximum number of generations that system currently supports.
      Console.WriteLine("Maximum generations: " + GC.MaxGeneration);
      // Create a new GenObj in the heap.   
      Object obj = new GenObj();
      //it returns the current genetation number. Because this object is newly created, it is in generation 0.   
      Console.WriteLine("First Created to Gen: " + GC.GetGeneration(obj)); // 0 

      // Performing a garbage collection promotes the object's generation.   
      GC.Collect();
      // it is in generation 1
      Console.WriteLine("Promoted to Gen: " + GC.GetGeneration(obj));

      GC.Collect();
      // it is in generation 2  
      Console.WriteLine("Promoted to Gen: " + GC.GetGeneration(obj));

      GC.Collect();
      Console.WriteLine("Promoted to Gen: " + GC.GetGeneration(obj));

      // Destroy the strong reference to this object.    
      obj = null;

      Console.WriteLine("Collecting Gen 0");
      GC.Collect(0);                    // Collect generation 0.
      GC.WaitForPendingFinalizers();    // Finalize is NOT called.

      Console.WriteLine("Collecting Gen 1");
      GC.Collect(1);                    // Collect generation 1.
      GC.WaitForPendingFinalizers();    // Finalize is NOT called.

      Console.WriteLine("Collecting Gen 2");
      GC.Collect(2);                    // Same as Collect()
      GC.WaitForPendingFinalizers();    // Finalize IS called.

    }
  }

  internal sealed class GenObj
  {
    public GenObj()
    {
      Console.WriteLine("Reserve memory");
    }
    ~GenObj()
    {
      Console.WriteLine("Free memory");
    }
  }

}
