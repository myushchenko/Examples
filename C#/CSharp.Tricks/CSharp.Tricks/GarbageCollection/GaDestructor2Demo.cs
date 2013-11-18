using System;

namespace CSharp.Tricks.GarbageCollection
{
  public class GaDestructor2Demo
  {
    public static void Run()
    {
      Console.WriteLine(string.Format("Memory before: {0:N2} MB", (GC.GetTotalMemory(false) / 1024f) / 1024f));

      int i = 1;
      using (MyClassDestructor2 obj = new MyClassDestructor2(0))
      {
        
        for (; i < 5; i++)
        {
          obj.objectGenerator(i);
        }

      } 


      MyClassDestructor3 obj3 = new MyClassDestructor3(0);
      for (; i < 290000; i++)
      {
        obj3.objectGenerator(i);
      }

      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("\nThe end!");
    }
  }

  public class MyClassDestructor2 : IDisposable
  {
    #region IDisposable Members

    public void Dispose()
    {
      Console.WriteLine(string.Format("Memory current: {0:N2} MB", (GC.GetTotalMemory(false) / 1024f) / 1024f));
      Console.WriteLine("Object {0} has been deleted!", k);
    }

    #endregion

    int k;

    public MyClassDestructor2(int i)
    {
      k = i;
    }

    ~MyClassDestructor2()
    {
      Console.WriteLine(string.Format("Memory current: {0:N2} MB", (GC.GetTotalMemory(false) / 1024f) / 1024f));
      Console.WriteLine("Object {0} has been deleted!", k);
    }
 
    // Метод создающий и тут же уничтожающий объект
    public void objectGenerator(int i)
    {
      MyClassDestructor2 ob = new MyClassDestructor2(i);
    }
  }

  public class MyClassDestructor3
  {
    int k;

    public MyClassDestructor3(int i)
    {
      k = i;
    }

    // Деструктор
    ~MyClassDestructor3()
    {
      //Console.WriteLine(string.Format("Memory current destructor3: {0:N2} MB", (GC.GetTotalMemory(false) / 1024f) / 1024f));

    }

    // Метод создающий и тут же уничтожающий объект
    public void objectGenerator(int i)
    {
      MyClassDestructor3 ob = new MyClassDestructor3(i);
    }
  }
}
