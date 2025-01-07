using System;

namespace csharpCalculator {
  class Program {
    static void Main (string[] args) {
      // Sum();
      // Subtraction();
      Division();
    }

    static void Sum () {
      Console.Clear();
      Console.WriteLine("First value: ");
      float firstValue = float.Parse(Console.ReadLine());

      Console.WriteLine("Second value: ");
      float secondValue = float.Parse(Console.ReadLine());

      Console.WriteLine($"Sum result: {firstValue + secondValue}");

      Console.ReadKey();
    }

    static void Subtraction () {
      Console.Clear();
      Console.WriteLine("First value: ");
      float firstValue = float.Parse(Console.ReadLine());

      Console.WriteLine("Second value: ");
      float secondValue = float.Parse(Console.ReadLine());

      Console.WriteLine($"Subtraction result: {firstValue - secondValue}");

      Console.ReadKey();
    }

    static void Division () {
      Console.Clear();
      Console.WriteLine("First value: ");
      float firstValue = float.Parse(Console.ReadLine());

      Console.WriteLine("Second value: ");
      float secondValue = float.Parse(Console.ReadLine());

      Console.WriteLine($"Division result: {firstValue / secondValue}");

      Console.ReadKey();
    }
  }
}
