using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int colon = 0;
            int underBar = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ':')
                {
                    colon++;
                }
                if (a[i] == '_')
                {
                    underBar++;
                }
            }

            Console.WriteLine(a.Length + colon + underBar * 5);
        }
    }
}