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
                string input = Console.ReadLine();
                if(input == null) 
                    break;
                string[] inputNum = input.Split();

                Console.WriteLine(int.Parse(inputNum[0]) + int.Parse(inputNum[1]));
            }
        }
    }
}