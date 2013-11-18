
using System;
using System.Collections.Generic;

namespace CSharp.Tricks.WeakReference
{
  public class ReconstituteWeakReferencetDemo
  {

    public static void Run()
    {
      Console.WriteLine(string.Format("Before we start, total mem alloc'd {0} bytes", GC.GetTotalMemory(false)));

      DogTest dog = new DogTest("Bowser");

      Console.WriteLine(string.Format("Total mem alloc'd now {0} bytes", GC.GetTotalMemory(false)));

      System.WeakReference dogRef = new System.WeakReference(dog);

      // Unref Bowser
      dog = null;
      GC.Collect();
      GC.WaitForPendingFinalizers();

      Console.WriteLine(string.Format("Total mem alloc'd now {0} bytes", GC.GetTotalMemory(false)));

      // Bowser is gone
      Console.WriteLine(string.Format("Object still alive: {0}", dogRef.IsAlive));

      // Hey, Bowser is alive again!
      DogTest newRef = DogTest.KeepDogRef;
      newRef.Bark();


      Console.WriteLine(string.Format("Total mem alloc'd now {0} bytes", GC.GetTotalMemory(false)));
    }

  }

  public class DogTest
  {
    public static DogTest KeepDogRef;

    public string Name { get; set; }

    public DogTest(string name)
    {
      Name = name;
    }

    ~DogTest()
    {
      Console.WriteLine("Dog destructor for " + Name + " called");
      DogTest.KeepDogRef = this;
    }

    public void Bark()
    {
      Console.WriteLine(Name + " : Woof");
    }
  }
}
