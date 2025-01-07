using System;

namespace csharpCalculator {
  class Program {
    static void Main (string[] args) {
      CalculatorMenu();
    }

    static void Sum () {
      Console.Clear();
      Console.WriteLine("First value: ");
      float firstValue = float.Parse(Console.ReadLine());

      Console.WriteLine("Second value: ");
      float secondValue = float.Parse(Console.ReadLine());

      Console.WriteLine($"Sum result: {firstValue + secondValue}");

      Console.ReadKey();
      CalculatorMenu();
    }

    static void Subtraction () {
      Console.Clear();
      Console.WriteLine("First value: ");
      float firstValue = float.Parse(Console.ReadLine());

      Console.WriteLine("Second value: ");
      float secondValue = float.Parse(Console.ReadLine());

      Console.WriteLine($"Subtraction result: {firstValue - secondValue}");

      Console.ReadKey();
      CalculatorMenu();
    }

    static void Division () {
      Console.Clear();
      Console.WriteLine("First value: ");
      float firstValue = float.Parse(Console.ReadLine());

      Console.WriteLine("Second value: ");
      float secondValue = float.Parse(Console.ReadLine());

      Console.WriteLine($"Division result: {firstValue / secondValue}");

      Console.ReadKey();
      CalculatorMenu();
    }

    static void Multiplication () {
      Console.Clear();
      Console.WriteLine("First value: ");
      float firstValue = float.Parse(Console.ReadLine());

      Console.WriteLine("Second value: ");
      float secondValue = float.Parse(Console.ReadLine());

      Console.WriteLine($"Multiplication result: {firstValue * secondValue}");

      Console.ReadKey();
      CalculatorMenu();
    }

    static void CalculatorMenu () {
      Console.Clear();

      Console.WriteLine("What type of calculation would you like to do?");
      Console.WriteLine("");
      Console.WriteLine("1 -> Sum");
      Console.WriteLine("2 -> Subtraction");
      Console.WriteLine("3 -> Division");
      Console.WriteLine("4 -> Multiplication");

      Console.WriteLine("----------/--------/--------");

      Console.WriteLine("Select one of the options above: ");
      short menuResult = short.Parse(Console.ReadLine());

      switch (menuResult) {
        case 1: Sum(); break;
        case 2: Subtraction(); break;
        case 3: Division(); break;
        case 4: Multiplication(); break;
        default: CalculatorMenu(); break;
      };  
    }
  }
}
