using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Tricks.Strings
{
  public class StringImmutableDemo
  {
    public static void Run()
    {
      Console.WriteLine("Example 1");
      string str1 = "string";
      string str2 = "string";
      Console.WriteLine("Is str2 the same reference as str1?: {0}", Object.ReferenceEquals(str1, str2));

      Console.WriteLine("\nExample 2");
      string s1 = "AGORA";
      string s2 = s1.Replace('A', 'Z');   // Replace A's with Z's
      string s3 = "A" + "G" + "O" + "R" + "A";
      string s4 = string.Intern("A" + "G" + "O" + "R" + "A");
      Console.WriteLine("s1 == '{0}'", s1);
      Console.WriteLine("s2 == '{0}'", s2);
      Console.WriteLine("Is s2 the same reference as s1?: {0}", Object.ReferenceEquals(s2, s1));
      Console.WriteLine("Is s3 the same reference as s1?: {0}", Object.ReferenceEquals(s3, s1));
      Console.WriteLine("Is s4 the same reference as s1?: {0}", Object.ReferenceEquals(s4, s1));
    }
  }
}
