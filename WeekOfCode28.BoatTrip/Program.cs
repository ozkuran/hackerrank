using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WeekOfCode28.BoatTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int c = Convert.ToInt32(tokens_n[1]);
            int m = Convert.ToInt32(tokens_n[2]);
            string[] p_temp = Console.ReadLine().Split(' ');
            int[] p = Array.ConvertAll(p_temp, Int32.Parse);
            bool yet = true;
            Int64 totalCapacity = c*m;
            if (n > 0)
            {
                foreach (Int64 i in p)
                {
                    if (i > totalCapacity)
                    {
                        yet = false;
                        break;
                    }
                }
            }
            if (yet)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
