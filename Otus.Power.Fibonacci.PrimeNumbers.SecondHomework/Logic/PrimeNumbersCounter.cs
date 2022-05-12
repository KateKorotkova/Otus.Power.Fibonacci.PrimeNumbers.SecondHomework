namespace Otus.Power.Fibonacci.PrimeNumbers.SecondHomework.Logic
{
    public class PrimeNumbersCounter
    {
        public long Count(int n)
        {
            var count = 0;
            for (var i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }

            return count;
        }

        private bool IsPrime(int n)
        {
            var counter = 0;
            for (var i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    counter++;
            }

            return counter == 2;
        }
    }
}
