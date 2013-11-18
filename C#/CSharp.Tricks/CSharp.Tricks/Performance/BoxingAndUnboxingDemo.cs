using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CSharp.Tricks.Performance
{
  public class BoxingAndUnboxingDemo
  {
   
    public static void Run()
    {
      Console.WriteLine("Start");
      
      Console.WriteLine("Init data");
      int[] array1 = new int[1024 * 1024];
      object[] array2 = new object[array1.Length];
      int[] array3 = new int[array1.Length];
      Random random = new Random();

      for (int index = 0; index < array1.Length; index++)
      {
        array1[index] = random.Next();
      }
      Stopwatch swBoxing = new Stopwatch();
      Console.WriteLine("Start Boxing");
      Console.WriteLine("Array:" + array1.Length);
      swBoxing.Start();

      for (int loop = 0; loop < 100; loop++)
      {
        for (int index = 0; index < array1.Length; index++)
        {
          array2[index] = array1[index];
        }
      }

      swBoxing.Stop();
      Console.WriteLine("Boxing: {0}", swBoxing.Elapsed);

      Stopwatch swUnboxing = new Stopwatch();
      swUnboxing.Start();

      for (int loop = 0; loop < 100; loop++)
      {
        for (int index = 0; index < array1.Length; index++)
        {
          array1[index] = (int)array2[index];
        }
      }

      swUnboxing.Stop();
      Console.WriteLine("Unboxing: {0}", swUnboxing.Elapsed);
      Console.WriteLine("Boxing/Unboxing: {0}", swBoxing.ElapsedTicks / swUnboxing.ElapsedTicks);

      Stopwatch swCopying = new Stopwatch();
      swCopying.Start();

      for (int loop = 0; loop < 100; loop++)
      {
        for (int index = 0; index < array1.Length; index++)
        {
          array3[index] = array1[index];
        }
      }

      swCopying.Stop();
      Console.WriteLine("Copying: {0}", swCopying.Elapsed);

      Console.WriteLine("Finish");
      Console.ReadKey();
    }

  }
}
