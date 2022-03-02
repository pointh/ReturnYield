using System;
using System.Collections.Generic;

namespace ReturnYield
{
    class Program
    {
        private static IEnumerable<long> Primes()
        {
            long candidate = 2;

            while (true)
            {
                int i = 2;
                while(i * i <= candidate)
                {
                    if (candidate % i++ == 0)
                    {
                        Console.WriteLine($"\t\t{candidate}");
                        candidate++;
                        i = 2;
                        continue;
                    }

                }
                yield return candidate;

                candidate++; // po vrácení z volané funkce
                if(candidate > 20)
                {
                    yield break; // ukonči další generování
                }
            }
        }

        static void Main(string[] args)
        {
            foreach(var x in Primes())
            {
                string s = x.ToString();
                if(s[s.Length-1] == '9')
                {
                    Console.WriteLine(s);
                }
                
            }          
        }
    }
}
