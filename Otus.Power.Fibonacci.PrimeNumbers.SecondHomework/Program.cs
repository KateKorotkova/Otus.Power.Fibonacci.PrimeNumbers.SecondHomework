using System;
using Otus.Power.Fibonacci.PrimeNumbers.SecondHomework.Logic;

namespace Otus.Power.Fibonacci.PrimeNumbers.SecondHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var powerCalculator = new CustomPower();
            var firstPower = powerCalculator.Calculate(2, 3);
            var secondPower = powerCalculator.Calculate(3, 4);
            Console.WriteLine($"2^3 = {firstPower}");
            Console.WriteLine($"3^4 = {secondPower}");


            var fibonacci = new Logic.Fibonacci();
            var firstFibonacci = fibonacci.CalculateViaRecursion(6);
            var secondFibonacci = fibonacci.CalculateViaIteration(9);
            Console.WriteLine($"Fibonacci (6) = {firstFibonacci}");
            Console.WriteLine($"Fibonacci (9) = {secondFibonacci}");


            var primeNumbersCounter = new PrimeNumbersCounter();
            var firstPrimeNumbersCount = primeNumbersCounter.Count(100);
            var secondPrimeNumbersCount = primeNumbersCounter.Count(1000);
            Console.WriteLine($"Prime numbers count (100) = {firstPrimeNumbersCount}");
            Console.WriteLine($"Prime number count (1000) = {secondPrimeNumbersCount}");


            Console.ReadKey();
        }
    }
}
