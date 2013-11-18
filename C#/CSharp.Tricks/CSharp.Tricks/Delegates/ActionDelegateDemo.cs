using System;

namespace CSharp.Tricks.Delegates
{
  public class ActionDelegateDemo
  {
    public static void Run()
    {

      Action<string> test1 = Method;
      test1("Test 1 ");

      Action<string> test2 = Console.WriteLine;
      test2("Test 2");

      Action<string, int> test3 = (t1, t2) => Console.WriteLine(string.Format("{0} {1}", t1, t2));
      test3("Test", 3);

      Action<string, int, bool> test4 = (t1, t2, t3) => Console.WriteLine(string.Format("{0} {1} is {2}", t1, t2, t3));
      test4("Test", 4, true);


      Action<string, int, bool> test5 = Method;
      test5("Test", 5, false);

    }

    private static void Method(string text, int number, bool isTrue)
    {
      Console.WriteLine(string.Format("{0} {1} is {2}", text, number, isTrue));
    }

    private static void Method(string text)
    {
      Console.WriteLine(text);
    }
  }
}
