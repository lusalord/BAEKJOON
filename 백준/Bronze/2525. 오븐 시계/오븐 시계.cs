using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_25_04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = int.Parse(Console.ReadLine());

            arr[0] += N / 60;
            arr[1] += N % 60;

            if(arr[1] >= 60)
            {
                arr[0]++;
                arr[1] -= 60;
            }
            if(arr[0] >= 24)
            {
                arr[0] -= 24;
            }
            Console.WriteLine(arr[0] + " " + arr[1]);
        }
    }
}
