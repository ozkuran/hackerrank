using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler005
{

    class Program
    {
        public static List<int> GetPrimes(int max)
        {
            var listOfPrimes = new List<int> {2};
            for (var i = 3; i <= max; i += 2)
            {
                var j = 0;
                var isPrime = true;
                while (listOfPrimes[j] * listOfPrimes[j] <= i)
                {
                    if (i % listOfPrimes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    j++;
                }
                if (isPrime)
                {
                    listOfPrimes.Add(i);
                }
            }
            return listOfPrimes;
        }

        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());
            for (var a0 = 0; a0 < t; a0++)
            {
                var n = Convert.ToInt32(Console.ReadLine());
                var primesUnderN = GetPrimes(n);
                var result = 1;

                foreach (var prime in primesUnderN)
                {
                    var floor = (int)Math.Floor(Math.Log(n) / Math.Log(prime));
                    result = result * ((int)Math.Pow(prime, floor));
                }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
