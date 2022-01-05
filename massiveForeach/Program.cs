using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiveForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4] { 1, 2, 3, 4 };
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
