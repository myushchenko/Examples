/*
 
Модификатор override позволяет переопределить метод базового класса помеченного модификатором virtual. 

Модификатор new скрывает в наследуемом классе метод базового класса.    

Рассмотрим четыре класса A, B1, B2 и C. Классы  B1, B2 и C  наследуют класс A, причем классы  B1 и B2 идентичны, отличаются только внутри метода writeLog(). 

Задача 1. Что произойдет если мы унаследуем базовый класс A, переопределим его метод. Сделаем явное приведение наследуемого класса к базовому и вызовем метод writeLog(). 

Задача 2. Что произойдет если мы унаследуем базовый класс A, скроем его метод. Сделаем явное приведение наследуемого класса к базовому и вызовем метод writeLog().  
 
 */

namespace CSharp.Tricks.OOP
{
  using System;
  public class PolymorphismDemo
  {
    public static void Run()
    {
      var a = new A();
      var b1 = new B1();
      var b2 = new B2();
      var c = new C();

      a.writeLog();
      b1.writeLog();
      c.writeLog();

      ((A)b1).writeLog();
      ((A)c).writeLog();

      //// Ошибка! Произойдет во время 
      // выполнения программы. 
      // Не удатmся преобразовать 
      // один тип к другому 
      //((B1)a).writeLog();
      //((C)a).writeLog();
      // Ошибка! Невозможно преобразовать 
      // один тип к другому
      //((B1)b2).writeLog();
    }


    /*
     Результат:
        class A
        class B1
        class C
        class B1
        class A <-- заметим, что после скрытия, вызвался метод базового класса
     
     */
  }

  class A
  {
    public virtual void writeLog()
    {
      Console.WriteLine("class A");
    }
  }

  class B1 : A
  {
    public override void writeLog()
    {
      Console.WriteLine("class B1");
    }
  }

  class B2 : A
  {
    public override void writeLog()
    {
      Console.WriteLine("class B2");
    }
  }

  class C : A
  {
    public new void writeLog()
    {
      Console.WriteLine("class C");
    }
  }
}
