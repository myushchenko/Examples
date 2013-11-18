
using System;
using System.Collections.Generic;

namespace CSharp.Tricks.WeakReference
{
  public class GarbageWeakReferencetDemo
  {
    
    public static void Run()
    {

      Dog dog = new Dog("demo");

      System.WeakReference dogRef = new System.WeakReference(dog);
      Console.WriteLine(string.Format("Object alive: {0}", dogRef.IsAlive));

      Dog origDog = (Dog)dogRef.Target;

      dog = null;
      GC.Collect();

      Console.WriteLine(string.Format("Object alive: {0}", dogRef.IsAlive));

      origDog = null;
      GC.Collect();

      Console.WriteLine(string.Format("Object alive: {0}", dogRef.IsAlive));
    }

  }

  class Dog
  {
    private string _name;
    public Dog(string name)
    {
      this._name = name;
    }

    ~Dog()
    {
      Console.WriteLine(string.Format("Object {0} =>: {1} has been deleted!", this.GetType().Name, _name));
    }
  }  
}
