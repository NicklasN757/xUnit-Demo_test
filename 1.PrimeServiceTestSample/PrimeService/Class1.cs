using System;

namespace PrimeService
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsBiggerThen10(int value)
        {
            if (value > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsBiggerThen20(int value)
        {
            if (value > 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
