using System;

namespace CSharp.Tricks.Delegates.ModernLanguageConstructs
{
  public class NormalDelegateDemo
  {

    public static void Run()
    {
      //  Part 4 - Instantiate the main object
      var obj = new TemperatureConverterImp();

      //  Part 5 - Intantiate delegate #1
      var delConvertToFahrenheit = new DelegateConvertTemperature(obj.ConvertToFahrenheit);

      //  Part 6 - Intantiate delegate #2
      var delConvertToCelsius = new DelegateConvertTemperature(obj.ConvertToCelsius);

      // Use delegates to accomplish work

      //  Part 7 - delegate #1
      double celsius = 0.0;
      double fahrenheit = delConvertToFahrenheit(celsius);
      string msg1 = string.Format("Celsius = {0}, Fahrenheit = {1}",
                                   celsius, fahrenheit);
      Console.WriteLine(msg1);

      //  Part 8 - delegate #2
      fahrenheit = 212.0;
      celsius = delConvertToCelsius(fahrenheit);
      string msg2 = string.Format("Celsius = {0}, Fahrenheit = {1}",
                                   celsius, fahrenheit);
      Console.WriteLine(msg2);
    }



  }

  // Part 1 - Explicit declaration of a delegate (helps a compiler ensure type safety)
  public delegate double DelegateConvertTemperature(double sourceTemp);

  // A sample class to play with
  class TemperatureConverterImp
  {
    // Part 2 - Will be attached to a delegate later in the code
    public double ConvertToFahrenheit(double celsius)
    {
      return (celsius * 9.0 / 5.0) + 32.0;
    }

    //  Part 3 - Will be attached to a delegate later in the code
    public double ConvertToCelsius(double fahrenheit)
    {
      return (fahrenheit - 32.0) * 5.0 / 9.0;
    }
  }

}
