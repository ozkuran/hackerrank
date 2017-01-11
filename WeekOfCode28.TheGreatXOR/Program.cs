using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOfCode28.TheGreatXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            List<int> numbersThatFit = new List<int>();
            for (int a0 = 0; a0 < q; a0++)
            {
                long x = Convert.ToInt64(Console.ReadLine());
                int temporaryCounter = 0;
                for (int i = 1; i < x; i++)
                {
                    if ((x ^ i) > x)
                    {
                        temporaryCounter++;
                    }
                }
                numbersThatFit.Add(temporaryCounter);
            }

            foreach (var i in numbersThatFit)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
