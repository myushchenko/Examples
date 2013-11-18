using System;
using System.Threading;

// Работа Деструктора.

namespace CSharp.Tricks.GarbageCollection.Details
{
  public class SimpleFinalize
  {
    public static void Run()
    {
      ResourceWrapperTest resource =  // Так как имеется сильная ссылка, сразу финализация не происходит.
                new ResourceWrapperTest();
      GC.Collect();
      //  resource = null;

      Console.WriteLine("\n\nНажмите любую клавишу для завершения работы");
      Console.WriteLine("и вызова (Деструктора) Finalize() сборщиком мусора");
      Console.WriteLine("для объектов предусматривающих финализацию в AppDomain.");

      // Задержка.
      Console.ReadKey();     
    }
    
  }

  public class ResourceWrapperTest
  {
    ~ResourceWrapperTest()
    {
      for (int i = 0; i < 1000; i++)
        Console.Write(".");
    }
  }
}
