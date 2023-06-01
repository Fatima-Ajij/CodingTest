namespace MegaPrime.CLI.Validation
{
    public class Validate
    {
        public static bool IsMegaPrime(uint number)
        {
            while (number > 0)
            {
                uint digit = number % 10;
                if (digit != 2 && digit != 3 && digit != 5 && digit != 7) return false;
                number /= 10;
            }
            return true;
        }

        public static bool IsPrime(uint number)
        {
            if (number == 1) return false;

            // check for all factors
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
