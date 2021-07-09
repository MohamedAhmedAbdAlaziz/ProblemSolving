using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string []t = Console.ReadLine().Split();
            int[] t1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                t1[i] = Convert.ToInt32(t[i]);
            }
            Array.Sort(t1);
            int C = 0;
            int result = 0;
            for (int i = n-1; i >=0; i--)
            {
                C += t1[i];
                int count = 0;
                for (int j = 0; j < i; j++)
                {
                    count += t1[j];
                }
                if (C > count)
                {
                  
                    result++;
                    break;
                }
                else
                {
                    result++;
                }

            }

            Console.WriteLine(result);
        }
    }
}
