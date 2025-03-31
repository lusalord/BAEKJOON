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
            StreamWriter Writer = new StreamWriter(Console.OpenStandardOutput());
            StreamReader Reader = new StreamReader(Console.OpenStandardInput());

            int a = int.Parse(Reader.ReadLine());

            for(int i = a; i > 0; i--)
            {
                Writer.WriteLine(i);
            }
            Writer.Close();
            Reader.Close();
        }
    }
}