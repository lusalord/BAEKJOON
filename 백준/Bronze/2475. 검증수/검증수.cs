using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;

            
            for(int i = 0; i < a.Length; i++)
            {
                count += (int)Math.Pow(a[i], 2);
            }
            count = count % 10;
            Console.WriteLine(count);
        }
    }
}