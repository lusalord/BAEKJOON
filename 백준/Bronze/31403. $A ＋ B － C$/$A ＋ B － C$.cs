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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string count;

            Console.WriteLine(a + b - c);

            count = a.ToString() + b.ToString();

            Console.WriteLine(int.Parse(count) - c);
        }
    }
}