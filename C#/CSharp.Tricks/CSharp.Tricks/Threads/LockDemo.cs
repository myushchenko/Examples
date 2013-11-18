using System;
using System.IO;
using System.Threading;

namespace CSharp.Tricks.Threads
{
  public class LockDemo
  {
    public static int index = -1;
    public static int count = 10;

    private static readonly object SyncIndex = new object();
    private static readonly object SyncFiles = new object();

    public static void Run()
    {
       CreateThreads(3);
    }


    public static void CreateThreads(int threads)
    {
      Thread[] threadArray;
      for (int i = 0; i < (threadArray = new Thread[threads]).Length; i++)
      {
        threadArray[i] = new Thread(Start) { IsBackground = true };
        threadArray[i].Start();
      }
    }

    public static void Start()
    {
      while (index < count)
      {
        // теперь из-за lock всё это выполняется считай в 1 поток...
        lock (SyncFiles)
        {
          if (index > count)
          {
            break;
          }
          else
          {
            index++;
            //Console.WriteLine(index.ToString());
            SaveText("file.txt", index.ToString());
          }
        }
        // теперь из-за lock всё это выполняется считай в 1 поток...
      }

    }

    private static void SaveText(string file, string text)
    {
      try
      {
        var write = new StreamWriter(file, false);
        write.WriteLine(text);
        write.Close();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    /*
     Результат:
        Moscow
        London
        New York
        Berlin
     
     */
  }
}
