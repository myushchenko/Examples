using System;
using CSharp.Tricks.Attributes;
using CSharp.Tricks.Collections;
using CSharp.Tricks.Delegates;
using CSharp.Tricks.Events;
using CSharp.Tricks.Exceptions;
using CSharp.Tricks.ExtensionMethods;
using CSharp.Tricks.GarbageCollection;
using CSharp.Tricks.GarbageCollection.Details;
using CSharp.Tricks.Generics;
using CSharp.Tricks.MyImmutable;
using CSharp.Tricks.OOP;
using CSharp.Tricks.OfficeExcel;
using CSharp.Tricks.Operators;
using CSharp.Tricks.Performance;
using CSharp.Tricks.Reflections;
using CSharp.Tricks.Strings;
using CSharp.Tricks.Threads;
using CSharp.Tricks.Delegates.ModernLanguageConstructs;
using CSharp.Tricks.WeakReference;

namespace CSharp.Tricks
{
  class Program
  {
    static void Main(string[] args)
    {

      /************************* Sample of Attributes *************************/
      // AttributesDemo 
      //AttributesDemo.Run();

      /************************* Sample of Collections *************************/
      // ArrayList 
      //ArrayListDemo.Run();
      // Yield Keyword Demo
      //YieldKeywordDemo.Run();
      // Yield Keyword Demo 2
      //YieldKeywordExtDemo.Run();

      /************************** Sample of delegate **************************/
      // Simple delegate
      //SimpleDelegateDemo.Run();

      // Group delegate
      //GroupDelegateDemo.Run();

      // Generic delegate
      //GenericDelegateDemo.Run();

      // Func delegate
      //FuncDelegateDemo.Run();

      // External variable Func delegate
      //ExternalVarFuncDelegateDemo.Run();

      // Action delegate
      //ActionDelegateDemo.Run();

      //Modern Language Constructs delegate samples
      //NormalDelegateDemo.Run();


      /************************* Sample of event *************************/
      // Simple event
      //EventSimpleDemo.Run();


      /************************* Sample of immutable ************************/

      // Sample of my immutable type
      //MyImmutableDemo.Run();

      /************************* Sample of Exceptions *************************/
      //Exceptions
      //ExceptionDemo.Run();

      /************************* Sample of Extension Method *************************/
      //Extension Method for Word Count 
      //ExtensionMethodDemo.Run();
      //Extension Enumerated Type 
      //ExtensionEnumeratedTypeDemo.Run();

      /********************** Sample of Garbage Collection********************/
      //Details
      //GCExample.Run();
      //SimpleGC.Run();
      //SimpleFinalize.Run();
      //SimpleDispose.Run();
      //SimpleDisposeRelease.Run();
      //FinalizableDisposableClass.Run();

      //Garbage Collection
      //GarbageCollectionDemo.Run();
      //Garbage Collection perfomence
      //GarbageCollection2Demo.Run();
      //Garbage Collection Destructor
      //GaDestructorDemo.Run();
      //Garbage Collection Destructor 2
      //GaDestructor2Demo.Run();
      //Garbage Collection Generation
      //GaGenerationDemo.Run();
      //Garbage Collection Generation 2
      //GaGeneration2Demo.Run();

      /****************************Generics********************************/
      //Generics class 
      //GenericClassDemo.Run();
      //Generics method
      //GenericMethodDemo.Run();
      //Hachset
      //HashSetDemo.Run();
      //Linked List 
      //LinkedListDemo.Run();

      /******************************OOP************************************/
      //Polymorphism
      //PolymorphismDemo.Run();

      /******************************Operators************************************/
      //Defining Operator 
      //DefiningOperatorDemo.Run();


      /******************************Performance************************************/
      //Boxing Vs Unboxing 
      //BoxingAndUnboxingDemo.Run();
      //Dictionary Vs ListDemo
      //DictionaryVsListDemo.Run();
      //StringBuilder Vs String
      //StringBuilderAndStringDemo.Run();

      /******************************Office Excel************************************/
      //Office Excel
      //OfficeExcelDemo.Run();

      //Static Constructor
      //StaticConstructorDemo.Run();

      /****************************Reflection******************************/
      //Access to private members of class
      //AccessPrivateMemeberDemo.Run();
      //Change private member in class
      //ChangePrivateMemeberDemo.Run();
      //Type Info class
      TypeInfoDemo.Run();

      /*****************************String**********************************/
      //String Intern
      //StringInternDemo.Run();
      //String Equality
      //StringEqualityDemo.Run();
      //String Immutable
      //StringImmutableDemo.Run();

      /******************************Threads********************************/
      //Lock sample
      //LockDemo.Run();
      //Async/Await sample
      //AsyncAwaitDemo.Run();


      /******************************WeakReferencet************************************/
      //WeakReferencet Cache 
      //WeakReferencetCacheDemo.Run();
      //Garbage WeakReferencet 
      //GarbageWeakReferencetDemo.Run();
      //Reconstitute Garbage WeakReferencet 
      //ReconstituteWeakReferencetDemo.Run();

      Console.ReadKey();
    }
  }
}
