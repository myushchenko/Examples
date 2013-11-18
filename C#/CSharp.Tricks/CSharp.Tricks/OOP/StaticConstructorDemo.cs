using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Tricks.OOP
{
  public class StaticConstructorDemo
  {
    public static void Run()
    {
      Console.WriteLine("new A().funk():");
      new A().funk();

      Console
       .WriteLine("\nnew B().funkNew():");
      new B().funkNew();

      Console
       .WriteLine("\n((A)new B()).funk():");
      ((A)new B()).funk();

      Console
      .WriteLine("\n((A)new B()).funkNew():");
      ((A)new B()).funkNew();
    }

    class A
    {
      // Модыфикаторы доступа нельзя ставить
      // на статические конструкторы
      //protected 
      static A()
      {
        Console.WriteLine("static A");
        // Нельзя вызывать не статические 
        // функции
        //funk();

      }

      public A()
      {
        Console.WriteLine("A");
      }

      public virtual void funk()
      {
        Console.WriteLine("A: funk");
      }

      public virtual void funkNew()
      {
        Console.WriteLine("A: funkNew");
      }

      // Ошибка! Статические члены класса 
      // не могут быть 
      // virtual, override или abstract 
      //public static virtual void funkSV()
      //{
      // Console.WriteLine("A: funckSV");
      //}
    }

    class B : A
    {
      static B()
      {
        Console.WriteLine("static B");
      }

      public B()
      {
        Console.WriteLine("B");
        base.funk();
        funk();
      }

      public override void funk()
      {
        Console.WriteLine("B: funk");
      }

      public new void funkNew()
      {
        Console.WriteLine("B: funkNew");
      }
    }
  }

  /*
   
Результат:

 new A().funk():
 static A
 A
 A: funk
 
 new B().funkNew():
 static B
 A
 B 
 A: funk  
 B: funk
 
 ((A)new B()).funk(): 
 B 
 A: funk  
 B: funkNew
 
 ((A)new B()).funkNew():
 A
 B 
 A: funk 
 A: funkNew  <- заметим, что вызывается метод базового класса
   
   */
}
