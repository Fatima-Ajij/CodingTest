using System;
using System.Collections.Generic;

namespace MegaPrime.CLI
{
    public class Application
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Please enter any number.");
                uint userInput = Convert.ToUInt32(Console.ReadLine());
                
                if (userInput == 0) Console.WriteLine("Sorry the maximum value should be 1.");
                else
                {
                    List<uint> megaPrimeNumbers = Process.GetMegaPrimeNumbers(userInput);
                    Console.Write($"[ ");
                    foreach (var megaPrimeNumber in megaPrimeNumbers)
                    {
                        Console.Write($"{megaPrimeNumber} ");
                    }
                    Console.Write($"]");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sorry..! The input range should not be negative or exceed to 4294967295");
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry..! This program only accept digits.");
            }
            Console.ReadKey();
        }
    }
}
