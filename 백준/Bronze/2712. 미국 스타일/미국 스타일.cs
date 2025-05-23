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

            for (int i = 0; i < a; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                float value = float.Parse(arr[0]);

                switch (arr[1])
                {
                    case "kg":
                        sb.AppendLine((value * 2.2046f).ToString("F4") + " lb");
                        break;
                    case "lb":
                        sb.AppendLine((value * 0.4536f).ToString("F4") + " kg");
                        break;
                    case "l":
                        sb.AppendLine((value * 0.2642f).ToString("F4") + " g");
                        break;
                    case "g":
                        sb.AppendLine((value * 3.7854f).ToString("F4") + " l");
                        break;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
