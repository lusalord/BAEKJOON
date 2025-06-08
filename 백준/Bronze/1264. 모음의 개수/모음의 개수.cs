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
            int v = 0;
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string a = Console.ReadLine();
                if (a == "#")
                {
                    break;
                }
                for (int i = 0; i  < a.Length; i++)
                {
                    switch (a[i])
                    {
                        case 'a':
                            v++;
                            break;
                        case 'e':
                            v++;
                            break;
                        case 'i':
                            v++;
                            break;
                        case 'o':
                            v++;
                            break;
                        case 'u':
                            v++;
                            break;
                        case 'A':
                            v++;
                            break;
                        case 'E':
                            v++;
                            break;
                        case 'I':
                            v++;
                            break;
                        case 'O':
                            v++;
                            break;
                        case 'U':
                            v++;
                            break;
                    }
                }
                sb.AppendLine(v.ToString());
                v = 0;
                
                
            }
            Console.WriteLine(sb.ToString());
        }
    }
}