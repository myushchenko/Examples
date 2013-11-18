using System;

namespace CSharp.Tricks.Delegates
{
  public class GroupDelegateDemo
  {
     
    public static void Run()
    {
      ProgressReport p = WriteProgressToConsole;
      p += WriteProgressToConsole2;
      p += WriteProgressToConsole3;
      //p += WriteProgressToFile;
      Util.HardWork(p);
    }

    static void WriteProgressToConsole(int percentComplete)
    {
      Console.WriteLine(percentComplete);
    }

    static void WriteProgressToConsole2(int percentComplete)
    {
      Console.WriteLine("Console2: "+percentComplete);
    }
    static void WriteProgressToConsole3(int percentComplete)
    {
      Console.WriteLine("Console3: " + percentComplete);
    }

    static void WriteProgressToFile(int percentComplete)
    {
      System.IO.File.AppendAllText("progress.txt", percentComplete.ToString()+" ");
    }
  }

  public delegate void ProgressReport(int parcentComplete);

  public partial class Util
  {
    public static void HardWork(ProgressReport p)
    {
      for (int i = 0; i < 10; i++)
        p(i*10);
      System.Threading.Thread.Sleep(100);
    }
  } 
}
