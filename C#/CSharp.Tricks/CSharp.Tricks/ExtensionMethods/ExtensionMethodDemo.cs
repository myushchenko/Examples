using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Tricks.ExtensionMethods
{
  using CustomExtensions;

  public class ExtensionMethodDemo
  {

    public static void Run()
    {
      ExtensionWordCount();
      ExtensionDistinctBy();
    }

    static readonly List<DemoClass> LstDemoClass = new List<DemoClass>
        {
          new DemoClass
            {
              Id = 1,
              Name = "test1"
            }, 
            new DemoClass
            {
              Id = 2,
              Name = "test2"
            },
            new DemoClass
            {
              Id = 1,
              Name = "test1"
            },
             new DemoClass
            {
              Id = 3,
              Name = "test3"
            }
        };

    private static void ExtensionWordCount()
    {
      Console.WriteLine("Extension: Word Count");

      var s = "The quick brown fox jumped over the lazy dog.";
      Console.WriteLine("Sample: " + s);
      int i = s.WordCount();
      Console.WriteLine("Word count of s is {0}", i);
    }

    private static void ExtensionDistinctBy()
    {
      Console.WriteLine("\nExtension: Distinct By");

      Console.WriteLine("Befor Distinct: ");
      LstDemoClass.ForEach(Print);

      Console.WriteLine("After Distinct: ");
      LstDemoClass.DistinctBy(t => t.Name).ToList().ForEach(Print);
    }

    private static void Print(DemoClass demoClass)
    {
      Console.WriteLine(string.Format("{0} => {1} ", demoClass.Id, demoClass.Name));
    }

  }

  public class DemoClass
  {
    public int Id { get; set; }

    public string Name { get; set; }
  }
}

namespace CustomExtensions
{
  using System;

  //Extension methods must be defined in a static class 
  public static class StringExtension
  {
    // This is the extension method. 
    // The first parameter takes the "this" modifier
    // and specifies the type for which the method is defined. 
    public static int WordCount(this String str)
    {
      return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
    {
      var knownKeys = new HashSet<TKey>();
      return source.Where(element => knownKeys.Add(keySelector(element)));
    }
  }
}
