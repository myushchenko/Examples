using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Tricks.ExtensionMethods
{
  using CustomExtensions;

  public class ExtensionEnumeratedTypeDemo
  {

    public static void Run()
    {
      DayOfWeek today = DayOfWeek.Thursday;
      Console.WriteLine(DayOfWeek.Thursday.ToString() + " => " + today.Activity());

      Console.WriteLine(DayOfWeek.Friday.ToString() + " => " + DayOfWeek.Friday.Activity());
    }

  }
}

namespace CustomExtensions
{
  using System;

  //Extension methods must be defined in a static class 
  public static class EnumeratedTypeExtension
  {
    public static string Activity(this DayOfWeek day)
    {
        string activity = "";
 
        switch (day)
        {
            case DayOfWeek.Sunday:
                activity = "Reading paper";
                break;
            case DayOfWeek.Monday:
                activity = "Grumbling";
                break;
            case DayOfWeek.Tuesday:
                activity = "Eating tacos";
                break;
            case DayOfWeek.Wednesday:
                activity = "Reading";
                break;
            case DayOfWeek.Thursday:
                activity = "Cursing";
                break;
            case DayOfWeek.Friday:
                activity = "Celebrating";
                break;
            case DayOfWeek.Saturday:
                activity = "Hiking";
                break;
        }
 
        return activity;
    }
}
 
}
