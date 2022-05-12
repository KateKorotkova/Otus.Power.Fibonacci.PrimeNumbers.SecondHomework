namespace Otus.Power.Fibonacci.PrimeNumbers.SecondHomework.Logic
{
    public class CustomPower
    {
        public long Calculate(int number, int pow)
        {
            var result = 1;
            for (var i = 1; i <= pow; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
