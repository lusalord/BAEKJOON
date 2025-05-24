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
            int a = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            
            for(int i = 0;  i < a; i++)
            {
                int sum = 0;
                int min = 100;

                
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int d = arr[0];
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] % 2 == 0)
                    {
                        sum += arr[j];
                        min = Math.Min(min, arr[j]);
                    }
                }
                sb.AppendLine(sum + " " + min);
               
            }
            Console.WriteLine(sb);
        }
    }
}