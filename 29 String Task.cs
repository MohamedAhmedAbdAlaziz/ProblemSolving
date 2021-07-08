using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            string t = Console.ReadLine();
            char[] t2 = t.ToCharArray();
            string[] lower = { "A", "O", "Y", "E", "U", "I" };
            string result = null;
            for (int i = 0; i < t2.Length; i++)
            {
                Boolean tr = true;
                for (int j = 0; j < 6; j++)
                {
                    if(t2[i].ToString().ToUpper()== lower[j])
                    {
                        tr = false;
                        break;
                    }
                }
                if(tr)
                {
                    result = result + "."+ t2[i].ToString().ToLower();

                }
            }
            Console.WriteLine(result);
        }
    }
}
