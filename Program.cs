using System;

namespace csharpCalculator {
  class Program {
    static void Main (string[] args) {
      Sum();
    }

    static void Sum () {
      Console.Clear();
      Console.WriteLine("First value: ");
      float firstValue = float.Parse(Console.ReadLine());

      Console.WriteLine("Second value: ");
      float secondValue = float.Parse(Console.ReadLine());

      Console.WriteLine($"Sum result: {firstValue + secondValue}");
    }
  }
}
