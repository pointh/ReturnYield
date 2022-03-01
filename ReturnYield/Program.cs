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
                        candidate++;
                        i = 2;
                        continue;
                    }

                }
                yield return candidate;
                candidate++;
            }
        }

        static void Main(string[] args)
        {
            foreach(var x in Primes())
            {
                string s = x.ToString();
                if(s[s.Length-1] == '1')
                {
                        Console.WriteLine(s);
                }
            }
        }
    }
}
