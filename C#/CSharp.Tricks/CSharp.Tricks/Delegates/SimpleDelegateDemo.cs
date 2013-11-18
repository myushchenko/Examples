using System;

namespace CSharp.Tricks.Delegates
{
  public class SimpleDelegateDemo
  {
    public delegate int CalculateNumber(int a, int b);

    public static void Run()
    {
      int a = 5;
      int b = 5;
      CalculateNumber addNumber = new CalculateNumber(AddNumber);
      Console.WriteLine(addNumber(5, 6));
      Console.ReadLine();
    }

    public static int AddNumber(int a, int b)
    {
      return a + b;
    }

    /*
     Результат:

     
     */
  }

}
