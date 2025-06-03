using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (arr[1] <= 2)
            {
                Console.WriteLine("NEWBIE!");
            }
            else if (arr[0] >= arr[1])
            {
                Console.WriteLine("OLDBIE!");
            }
            else if(!(arr[1] == 0 || arr[1] == 1) || !(arr[0] > arr[1]))
            {
                Console.WriteLine("TLE!");
            }
        }
    }
}