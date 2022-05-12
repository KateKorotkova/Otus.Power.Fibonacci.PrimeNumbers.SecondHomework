namespace Otus.Power.Fibonacci.PrimeNumbers.SecondHomework.Logic
{
    public class Fibonacci
    {
        public long CalculateViaRecursion(int n)
        {
            if (n == 1 || n == 2)
                return 1;

            return CalculateViaRecursion(n - 1) + CalculateViaRecursion (n -2);
        }

        public long CalculateViaIteration(int n)
        {
            var firstFibonacci = 1;
            var secondFibonacci = 1;
            
            var result = 1;
            for (var i = 3; i <= n; i++)
            {
                result = firstFibonacci + secondFibonacci;
                firstFibonacci = secondFibonacci;
                secondFibonacci = result;
            }

            return result;
        }
    }
}
