using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            bool f = false;
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            foreach (int a in array)
            {
                if (a == 3)
                {
                    Console.WriteLine("Элемент 3 найден");
                    f = true;
                    break;
                }
            }
            if (!f)
            {
                Console.WriteLine("Нет таких элементов");
            }
            Console.ReadKey();
        }
    }
}
