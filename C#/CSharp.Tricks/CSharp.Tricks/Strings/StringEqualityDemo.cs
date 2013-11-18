using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Tricks.Strings
{
  public class StringEqualityDemo
  {
    public static void Run()
    {
      string s1 = "foo";
      string s2 = s1;
      string s3 = "foo";
      string s4 = "bar";
      Console.WriteLine(s1 == s3);
      Console.WriteLine(s1 == s4);
      Console.WriteLine((Object)s1 == (Object)s3);
      Console.WriteLine((Object)s1 == (Object)s2);
    }
  }
}
