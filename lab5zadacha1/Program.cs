using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array = new int[n];
            int s = 0;
            float med = 0;
            Console.WriteLine("Укажи 7 чисел для одномерного массива:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
            }
            Console.WriteLine();
            med = s / 7;
            Console.WriteLine("Среднее арифметическое масиива: {0:f2}", med);
            Console.ReadKey();
        }
    }
}
