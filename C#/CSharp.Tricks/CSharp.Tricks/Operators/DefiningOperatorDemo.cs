using System;
using System.Collections.Generic;

namespace CSharp.Tricks.Operators
{
  public class DefiningOperatorDemo
  {
    public static void Run()
    {
      DogOper k = new DogOper("Kirby", 13);
      DogOper j = new DogOper("Jack", 15);

      DogOper mutant = k + j;

      Console.WriteLine(mutant.Name +"  "+ mutant.Age);
    }

  }

  class DogOper
  {
    private string _name;
    private int _age;

    public int Age
    {
      get { return _age; }
      set { _age = value; }
    }

    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    public DogOper(string name, int age)
    {
      this._name = name;
      this._age = age;

    }
    public static DogOper operator +(DogOper d1, DogOper d2)
    {
      return new DogOper(d1.Name + d2.Name, d1.Age + d2.Age);
    }
  }
}
