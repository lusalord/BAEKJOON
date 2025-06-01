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

            if (a == "M")
            {
                Console.WriteLine("MatKor");
            }
            else if (a == "W")
            {
                Console.WriteLine("WiCys");
            }
            else if (a == "C")
            {
                Console.WriteLine("CyKor");
            }
            else if (a == "A")
            {
                Console.WriteLine("AlKor");
            }
            else
            {
                Console.WriteLine("$clear");
            }
        }
    }
}