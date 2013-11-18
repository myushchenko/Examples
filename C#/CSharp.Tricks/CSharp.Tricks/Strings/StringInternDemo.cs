using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Tricks.Strings
{
  public class StringInternDemo
  {
    public static void Run()
    {
      string s1 = "MyTestNew";
      string s2 =  new StringBuilder().Append("My").Append("Test").Append("New").ToString();
      string s3 = string.Intern(s2);
      Console.WriteLine("s1 == '{0}'", s1);
      Console.WriteLine("s2 == '{0}'", s2);
      Console.WriteLine("s3 == '{0}'", s3);
      Console.WriteLine("Is s2 the same reference as s1?: {0}", Object.ReferenceEquals(s2, s1));
      Console.WriteLine("Is s3 the same reference as s1?: {0}", Object.ReferenceEquals(s3, s1));
    }
  }
}
