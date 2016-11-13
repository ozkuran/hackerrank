using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Solution
    {
        static void Main(string[] args)
        {
            double net = double.Parse(Console.ReadLine());
            double tip = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            Console.WriteLine("The total meal cost is " + Math.Round(net + (net * tip / 100) + (net * tax / 100)) + " dollars.");
        }
    }
}
