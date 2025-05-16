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
            string a = Console.ReadLine();

            for(int i = 0; i < a.Length; i++)
            {
                if (Char.IsLower(a[i]))
                {
                    Console.Write(char.ToUpper(a[i]));
                }
                else
                {
                    Console.Write(char.ToLower(a[i]));
                }
            }

        }
    }
}