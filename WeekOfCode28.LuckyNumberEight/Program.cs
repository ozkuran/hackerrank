using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOfCode28.LuckyNumberEight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("0");
            }
            string number = Console.ReadLine();
            var query = from i in Enumerable.Range(0, number.Length)
                        from j in Enumerable.Range(0, number.Length - i + 1)
                        where j >= 1
                        select Int32.Parse(number.Substring(i, j)) % 1000;
            int counter = 0;
            foreach (var i in query)
            {
                if ((i%8) == 0) counter++;
            }
            Console.WriteLine(counter % 1000000007);
            Console.ReadLine();
        }
    }
}
