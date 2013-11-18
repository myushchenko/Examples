using System;

namespace CSharp.Tricks.Delegates
{
  public class FuncDelegateDemo
  {

    public static void Run()
    {
      Method1();
      Method2();
    }

    static void Method1()
    {
      /**Самый простой вариант Func это Func<TResult>. Этот делегат представляет метод, который возвращает 
       значение и при этом не имеет никаких параметров. Новый делегат использует анонимный метод, 
       который возвращает double значение. Код ниже демонстрирует это.*/

      Func<double> doub = delegate { return 34.4; };
      Console.WriteLine(doub());

      /*Такую же функциональность можно реализовать при помощи лямбда-выражений:*/
      Func<double> doubLamb = () => { return 34.4; };
      Console.WriteLine(doubLamb());

      /*А теперь проделаем тоже самое, но только уже с параметрами:*/
      Func<byte, byte, byte, int> plus = delegate(byte q, byte w, byte e) { return q + w + e; };
      Console.WriteLine(plus(1, 2, 3));

      /*А теперь тоже самое, только уже через лямбда-выражения:*/
      Func<byte, byte, byte, int> plusLumb = (byte q, byte w, byte e) => { return q + w + e; };
      Console.WriteLine(plusLumb(4, 5, 6));
    }

    static void Method2()
    {
      int[] values = { 1, 2, 3 };
      Util2.Transform(values, Square);// затрагиваем Square 
      foreach (int i in values)
        Console.Write(i + "");// 149 
    }

    static int Square(int x)
    {
      return x * x;
    } 
  }

  public class Util2
  {
    public static void Transform<T>(T[] values, Func<T, T> transformer)
    {
      for (int i = 0; i < values.Length; i++)
        values[i] = transformer(values[i]);
    }
  } 
}
