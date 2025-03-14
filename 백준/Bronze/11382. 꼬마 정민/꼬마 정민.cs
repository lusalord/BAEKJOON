using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_2025_03_06
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

            Console.WriteLine(arr[0] + arr[1] + arr[2]);
        }
    }
}