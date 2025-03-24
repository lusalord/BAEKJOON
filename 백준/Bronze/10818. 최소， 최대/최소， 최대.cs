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
            int N = int.Parse(Console.ReadLine());
            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] count = new int[2];

            count[0] = num[0];
            count[1] = num[0];

            for (int i = 0; i < N; i++)
            {
                if (count[0] < num[i])
                {
                    count[0] = num[i];
                }

                if(count[1] > num[i])
                {
                    count[1] = num[i];
                }
            }
            Console.WriteLine(count[1] + " " + count[0]);
        }
    }
}