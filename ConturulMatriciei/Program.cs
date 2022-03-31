using System;

namespace ConturulMatriciei
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            
            int n = 7;
            int m = 12;
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(10);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)

                    Console.Write(a[i, j] + " ");
                Console.WriteLine();               
            }
           

            for (int i = 0; i < m - 1; i++)
            {
                Console.Write(a[0, i]);
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(a[i, m - 1]);
            }
            for (int i = m- 1; i >= 1 ; i--)
            {
                Console.Write(a[n - 1, i]);
            }
            for (int i = n - 1; i > 0; i--)
            {
                Console.Write(a[i, 0]);
            }

            Console.ReadKey();
        }
    }
}
