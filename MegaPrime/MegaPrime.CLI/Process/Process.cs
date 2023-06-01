using System.Collections.Generic;
using MegaPrime.CLI.Validation;
namespace MegaPrime.CLI
{
    public class Process
    {
        private static readonly List<uint> _megaPrimeNumbers;
        static Process()
        {
            _megaPrimeNumbers = new List<uint>();
        }
        /// <summary>
        /// Returns Mega Prime numbers
        /// </summary>
        /// <returns></returns>
        public static List<uint> GetMegaPrimeNumbers(uint number) {
            
            while (number>0) { 
                if (Validate.IsMegaPrime(number) && Validate.IsPrime(number))
                {
                    _megaPrimeNumbers.Add(number);
                }
                number--;
            }
            return _megaPrimeNumbers;
        }
         
    }
}
