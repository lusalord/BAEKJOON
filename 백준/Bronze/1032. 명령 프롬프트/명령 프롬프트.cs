using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];

            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
            }

            string a = input[0];

            for(int i = 1; i < n; i++)
            {
                string b = input[i];
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] != b[j])
                    {
                        a = a.Substring(0, j) + '?' + a.Substring(j + 1);
                    }
                }
            }
            Console.WriteLine(a);
        }
    }
}