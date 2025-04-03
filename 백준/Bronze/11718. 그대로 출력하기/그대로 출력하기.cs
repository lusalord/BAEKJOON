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
            
            while (true)
            {
                string arg = Console.ReadLine();

                if(string.IsNullOrEmpty(arg))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(arg);
                }
            }
           
        }
    }
}