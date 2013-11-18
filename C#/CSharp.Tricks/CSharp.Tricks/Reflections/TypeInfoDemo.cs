using System;
using System.Reflection;

namespace CSharp.Tricks.Reflections
{
  public class TypeInfoDemo
  {
    public static void Run()
    {
      // Get the Type Using GetType() static method
      //Type T = Type.GetType("CSharp.Tricks.Reflections.Customer");

      //To get the type information we have the following 2 ways as well.
      //Use typeof keyowrd
      Type T = typeof(Customer);


      //Use GetType() on the instance of the customer class. 
      //Customer C1 = new Customer();
      //Type T = C1.GetType();


      // Print the Type details
      Console.WriteLine("Full Name = {0}", T.FullName);
      Console.WriteLine("Just the Class Name = {0}", T.Name);
      Console.WriteLine("Just the Namespace = {0}", T.Namespace);
      Console.WriteLine();

      // Print the list of Methods
      Console.WriteLine("Methods in Customer Class");
      MethodInfo[] methods = T.GetMethods();
      foreach (MethodInfo method in methods)
      {
        // Print the Return type and the name of the method
        Console.WriteLine(method.ReturnType.Name + " " + method.Name);
      }
      Console.WriteLine();

      //  Print the Properties
      Console.WriteLine("Properties in Customer Class");
      PropertyInfo[] properties = T.GetProperties();
      foreach (PropertyInfo property in properties)
      {
        // Print the property type and the name of the property
        Console.WriteLine(property.PropertyType.Name + " " + property.Name);
      }
      Console.WriteLine();

      //  Print the Constructors
      Console.WriteLine("Constructors in Customer Class");
      ConstructorInfo[] constructors = T.GetConstructors();
      foreach (ConstructorInfo constructor in constructors)
      {
        Console.WriteLine(constructor.ToString());
      }
    }
  }

  public class Customer
  {
    public int Id { get; set; }
    public string Name { get; set; }


    public Customer(int ID, string Name)
    {
      this.Id = ID;
      this.Name = Name;
    }


    public Customer()
    {
      this.Id = -1;
      this.Name = string.Empty;
    }


    public void PrintID()
    {
      Console.WriteLine("ID = {0}", this.Id);
    }
    public void PrintName()
    {
      Console.WriteLine("Name = {0}", this.Name);
    }
  }

}
