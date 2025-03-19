using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] TimeAlam = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (TimeAlam[1] < 45)
            {
                TimeAlam[0]--;
                TimeAlam[1] = 60 - (45 - TimeAlam[1]);
                if (TimeAlam[0] < 0)
                {
                    TimeAlam[0] = 23;
                }
            }
            else
            {
                TimeAlam[1] = TimeAlam[1] - 45;
            }
            Console.Write(TimeAlam[0]);
            Console.Write(" ");
            Console.Write(TimeAlam[1]);
        }
    }
}