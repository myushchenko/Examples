using System;
using System.Reflection;

namespace CSharp.Tricks.Reflections
{
  public class AccessPrivateMemeberDemo
  {
    public static void Run()
    {
      Another another = new Another();
      Type type = another.GetType();

      MethodInfo metin = type.GetMethod("Hex", BindingFlags.Instance | BindingFlags.NonPublic);
      metin.Invoke(another, null);
    }
  }

   class Another
    {
        void Hex()
        {
            Console.WriteLine("You are bigger!!");
            Console.ReadLine();
        }
    }
}
