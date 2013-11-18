using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.Tricks.Threads
{
  public class AsyncAwaitDemo
  {
    
    public static void Run()
    {
      Console.WriteLine("Main start");
      Task t = AsyncMethod();
      t.ContinueWith((str) =>
      {
        Console.WriteLine(str.Status.ToString());
        Console.WriteLine("Main end");
      });
      t.Wait();
    }

    public async static Task<string> AsyncMethod()
    {
      Console.WriteLine("public async static  void asyncMethod() start");
      await Task.Delay(100);
      Thread.Sleep(1000);
      Console.WriteLine("public async static  void asyncMethod() Step 1");
      await Task.Delay(100);
      Thread.Sleep(1000);
      Console.WriteLine("public async static  void asyncMethod() Step 2");
      await Task.Delay(100);
      Thread.Sleep(1000);
      Console.WriteLine("public async static  void asyncMethod() Step 3");
      await Task.Delay(100);
      Thread.Sleep(1000);
      Console.WriteLine("public async static  void asyncMethod() end");
      return "finished";
    }   
  }
}
