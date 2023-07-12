// See https://aka.ms/new-console-template for more information
using CalculatorFibonacci;

Console.WriteLine($"0 = {Fibonacci.FibonacciWithFor(0).ToString("N")}");
Console.WriteLine($"1 = {Fibonacci.FibonacciWithFor(1).ToString("N")}");
Console.WriteLine($"2 = {Fibonacci.FibonacciWithFor(2).ToString("N")}");
Console.WriteLine($"5 = {Fibonacci.FibonacciWithFor(5).ToString("N")}");
Console.WriteLine($"20 = {Fibonacci.FibonacciWithFor(20).ToString("N")}");
Console.WriteLine($"35 = {Fibonacci.FibonacciWithFor(35).ToString("N")}");

Console.WriteLine($"0 = {Fibonacci.FibonacciWithRecursion(0).ToString("N")}");
Console.WriteLine($"1 = {Fibonacci.FibonacciWithRecursion(1).ToString("N")}");
Console.WriteLine($"2 = {Fibonacci.FibonacciWithRecursion(2).ToString("N")}");
Console.WriteLine($"5 = {Fibonacci.FibonacciWithRecursion(5).ToString("N")}");
Console.WriteLine($"20 = {Fibonacci.FibonacciWithRecursion(20).ToString("N")}");
Console.WriteLine($"35 = {Fibonacci.FibonacciWithRecursion(35).ToString("N")}");
