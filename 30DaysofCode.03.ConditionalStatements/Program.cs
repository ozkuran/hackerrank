using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysofCode._03.ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string result = "";
            if (N % 2 != 0)
            {
                result = "Weird";
            }
            else if (N % 2 == 0 && N >= 2 && N <= 5)
            {
                result = "Not Weird";
            }
            else if (N % 2 == 0 && N >= 6 && N <= 20)
            {
                result = "Weird";
            }
            else if (N % 2 == 0 && N > 20)
            {
                result = "Not Weird";
            }
            Console.WriteLine(result);
        }
    }
}
