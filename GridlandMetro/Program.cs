using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridlandMetro
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("in.txt");
            var x = file.ReadLine().Trim().Split(' ').Select(Int32.Parse).ToList();
            int n_cols = x[0];
            int m_rows = x[1];
            int k_trackCount = x[2];
            var sum = 0;
            Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
            for (var i = 0; i < k_trackCount; i++)
            {
                var y = file.ReadLine().Trim().Split(' ').Select(Int32.Parse).ToList();
                int row = y[0];
                int start = y[1];
                int end = y[2];
                if (!dictionary.Keys.Contains(row))
                {
                    dictionary.Add(row, Enumerable.Range(start, (end - start) + 1).ToList());
                }
                else
                {
                    for (var j = start; j <= end; j++)
                    {
                        if (!dictionary[row].Contains(j))
                        {
                            dictionary[row].Add(j);
                        }
                    }
                }
                foreach (int item in dictionary.Keys)
                {
                    sum += dictionary[item].Count;
                }
            }
            Console.WriteLine((n_cols * m_rows) - sum);

        }
    }
}
