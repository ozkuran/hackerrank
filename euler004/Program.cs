using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler004
{
    class Program
    {
        public static bool IsPalindrome(long number)
        {
            long n = number;
            long reverse = 0;
            long temp = 0;
            while (number > 0)
            {
                temp = number % 10;
                reverse = reverse * 10 + temp;
                number = number / 10;
            }
            return (n == reverse);
        }

        static void Main(String[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());
            long palindrome = 0;
            long result = 0;
            SortedSet<long> palindromeList = new SortedSet<long>();
            for (int i = 100; i <= 999; i++)
            {
                result = 0;
                for (int j = i; j <= 999; j++)
                {
                    result = i * j;
                    if (IsPalindrome(result))
                    {
                        palindromeList.Add(result);
                    }
                }
            }
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                palindrome = 0;
                foreach (long i in palindromeList)
                {
                    if (i < n)
                    {
                        palindrome = i;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(palindrome);
            }
        }
    }
}
