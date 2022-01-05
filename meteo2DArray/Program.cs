using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meteo2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 30;
            const int m = 3;
            int[,] t = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                float sum = 0;
                for (int j = 0; j < m; j++)
                {
                    t[i, j] = random.Next(-10, 20);
                    sum += t[i, j];
                    Console.Write("{0,4} ", t[i, j]);
                }
                Console.WriteLine("{0,8:f1}",sum/3);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
