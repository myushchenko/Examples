using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Tricks.Exceptions
{
  public class ExceptionDemo
  {
    public static void Run()
    {
      try
      {
        try
        {
          Console.WriteLine("Moscow");
          throw new
           System.ArgumentNullException();
          Console.WriteLine("Kiev");
        }
        catch (System.ArgumentNullException)
        {
          Console.WriteLine("London");
          throw;
          Console.WriteLine("Minsk");
        }
        catch (System.ArgumentException)
        {
          Console.WriteLine("Paris");
        }
        finally
        {
          Console.WriteLine("New York");
        }
      }
      catch (System.Exception)
      {
        Console.WriteLine("Berlin");
      }
    }

    /*
     Результат:
        Moscow
        London
        New York
        Berlin
     
     */
  }
}
