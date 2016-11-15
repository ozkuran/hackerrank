using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler008
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string num = Console.ReadLine();
                double max = 0;
                for (int j = 0; j + k <= n; j++)
                {
                    double result = 1;
                    for (int i = 0; i < k; i++)
                    {
                        result *= num[i+j]-48;
                    }
                    if (result > max)
                    {
                        max = result;
                    }
                }
                Console.WriteLine(max);
            }

        }
    }
}
