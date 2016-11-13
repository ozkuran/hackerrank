using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace euler006
{
    class Program
    {

        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());
            for (var a0 = 0; a0 < t; a0++)
            {
                var n = Convert.ToInt32(Console.ReadLine());
                BigInteger sumOfSquares = 0;
                BigInteger squareOfSums = 0;
                sumOfSquares = ((n * (n + 1) * (2 * n + 1)) / 6);
                squareOfSums = (n * (n + 1)) / 2;
                squareOfSums = squareOfSums * squareOfSums;
                Console.WriteLine(squareOfSums - sumOfSquares);
            }
            Console.ReadLine();
        }
    }
}
