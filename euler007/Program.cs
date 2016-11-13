using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace euler007
{
    class Program
    {
        static List<BigInteger> Sieve(int topPrime)
        {
            BitArray al = new BitArray(topPrime, true);

            int index = 1;
            int square = 1;

            while (square <= topPrime)
            {
                index++;

                while (!(bool)al[index])
                    index++;

                square = index * index;

                for (int i = square; i < topPrime; i += index)
                    if (i > 0)
                        al[i] = false;
            }

            List<BigInteger> sieve = new List<BigInteger>();

            for (int i = 2; i < topPrime; i++)
                if (al[i])
                    sieve.Add(i);

            return sieve;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                var n = Convert.ToInt32(Console.ReadLine());
                var primeList = Sieve(105000);
                Console.WriteLine(primeList[n-1]);
            }
        }
    }
}
