using System;
using System.IO;

namespace Algoritm_Algebra_Matrice
{
    class Program
    {
        static void viewMatrix(int [,]matrix )
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }           
        }
        static int[,] matrixRead(string fileName)
        {
            TextReader load = new StreamReader(fileName);
            string[] t = load.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int m = int.Parse(t[1]);
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] buffer = load.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(buffer [j]);
                }
            }
            return a;
        }


        static void Main(string[] args)
        {
            int[,] t = matrixRead(@"../../TextFile1.txt");
            int n = t.GetLength(0);
            int m = t.GetLength(1);
            viewMatrix(t);

            int[,] q = new int[2 * n - 1, 2 * m - 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    q[i * 2, j * 2] = t[i, j];
                }
            }
            //aici am lucrat cu matricea t 
            //etapa II
            for (int i = 0; i < 2 * n - 1 ; i += 2)
            {
                for (int j = 1; j < 2 * m  - 1 ; j += 2)
                {
                    q[i, j] = (q[i, j - 1] + q[i, j + 1]) / 2; 
                }
            }
            
            //etapa III
            for (int i = 1; i < 2 * n -1; i += 2)
            {
                for (int j = 0; j < 2 * m - 1; j++)
                {
                    q[i, j] = (q[i - 1, j] + q[i + 1, j]) / 2;
                }
            }
            Console.WriteLine();
            viewMatrix(q);
            Console.WriteLine();
            int[,] p = new int[n, m];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int s = 0;
                    int nr = 0;
                    if(i - 1 >= 0 && j - 1 >= 0 )
                    {
                        s += t[i- 1 , j - 1];
                        nr++;
                    }
                    if (i - 1 >= 0)
                    {
                        s += t[i - 1, j];
                        nr++;
                    }
                    if (i - 1 >= 0 && j + 1 < m)
                    {
                        s += t[i - 1, j + 1];
                        nr++;
                    }
                    p[i, j] = s / nr;
                }
            }
            //blure
            Console.ReadKey();           
        }
    }
}
