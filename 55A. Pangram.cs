using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string str = Console.ReadLine().ToUpper();
           

            if (t < 26) {
                Console.WriteLine("NO");
            }
            else
            {
                int i;
                for (i = 0; i < alpha.Length; i++)
                {
                    string s = alpha[i].ToString();
                    int t2 = str.IndexOf(s);
                    if (t2 <0)
                    {
                        Console.WriteLine("No");
                        break;

                    }

                   
                }
                if (i == alpha.Length)
                {
                    Console.WriteLine("YES");
                }
            }
         
            





            //    string t = Console.ReadLine().Split("WUB").ToString();
            // string[] t2 = t.Split("");

        //    string t = Console.ReadLine();
        //  string l= t.Remove(0, 3);
        //  int k=  l.Length - 1 ;
        //      int  k2 = l.Length - 3;

        //string l2=    l.Remove(k2, 3);
        //    int t33 = l.IndexOf("WUBgg");

        //    foreach (var item in t)
        //    {
        //        Console.Write(item+ " ");
        //    }      
        }
    }
}
