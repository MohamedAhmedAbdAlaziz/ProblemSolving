using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            string []t = Console.ReadLine().Split();
            int n = Convert.ToInt32(t[0]);
            int k = Convert.ToInt32(t[1]);
            string[] a= Console.ReadLine().Split();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if(Convert.ToInt32(a[i]) > 0&& Convert.ToInt32(a[i])>= Convert.ToInt32(a[k-1]))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
