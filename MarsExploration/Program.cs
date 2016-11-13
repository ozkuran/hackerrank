using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int errorCount = 0;
            while (S.Length > 0)
            {
                if (S[0] != 'S')
                {
                    errorCount++;
                }
                S= S.Remove(0,1);
                if (S[0] != 'O')
                {
                    errorCount++;
                }
                S = S.Remove(0,1);
                if (S[0] != 'S')
                {
                    errorCount++;
                }
                S = S.Remove(0,1);
            }
            Console.WriteLine(errorCount);

        }
    }
}
