using System;
using System.Collections.Generic;
using System.Linq;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            List<(int, string)> list = new List<(int, string)>();

            for (int i = 0; i < a; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');

                list.Add((int.Parse(arr[0]), arr[1]));
            }

            List<(int, string)> sort = list.OrderBy(x => x.Item1).ToList();

            for (int i = 0; i < sort.Count; i++)
            {
                Console.WriteLine($"{sort[i].Item1} {sort[i].Item2}");
            }
        }
    }
}