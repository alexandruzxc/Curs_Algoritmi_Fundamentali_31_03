using System;

namespace PbInfo_ConsoleApp_1749
{
    class Program
    {
        static void Main(string[] args)
        {
            string []t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int k = int.Parse(t[1]);
            int[,] m = new int[n, n];

            int Sn = 0;
            int Sv = 0;
            int Se = 0;
            int Ss = 0;

            for (int i = 0; i < n; i++)
            {
                string[] buffer = Console.ReadLine().Split(' '); 
                for (int j = 0; j < n; j++)               
                    m[i, j] = int.Parse(buffer[j]);                
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j && i + j < n - 1)
                        Sn += m[i, j];
                    if (i < j && i + j > n - 1)
                        Se += m[i, j];
                    if (i > j && i + j > n - 1)
                        Ss += m[i, j];
                    if (i > j && i + j < n - 1)
                        Sv += m[i, j];
                }
            }
            switch (k)
            {
                case 1: Console.Write(Sn); break;
                case 2: Console.Write(Se); break;
                case 3: Console.Write(Ss); break;
                case 4: Console.Write(Sv); break;                   
            }
            Console.ReadKey();
        }
    }
}
