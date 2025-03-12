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
            double[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

            Console.WriteLine(arr[0] / arr[1]);
        }
    }
}