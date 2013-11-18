using System;

namespace CSharp.Tricks.GarbageCollection
{
  public class GaDestructorDemo
  {
    public static void Run()
    {
      int i = 1;
      MyClassDestructor obj = new MyClassDestructor(0);

      for (; i < 10; i++)
      {
        obj.objectGenerator(i);
        System.GC.Collect();
        System.GC.WaitForPendingFinalizers();
      }

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nThe end!");
   }
  }

  class MyClassDestructor
  {
    int k;

    public MyClassDestructor(int i)
    {
      k = i;
    }

    // Деструктор
    ~MyClassDestructor()
    {
      Console.WriteLine("Object {0} has been deleted!", k);
    }

    // Метод создающий и тут же уничтожающий объект
    public void objectGenerator(int i)
    {
      MyClassDestructor ob = new MyClassDestructor(i);
    }
  }


}
