using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            Queue queue = new Queue();

            int n = int.Parse(Console.ReadLine());
            

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                switch (input[0])
                {
                    case "push":
                        queue.Enqueue(int.Parse(input[1]));
                        break;
                    case "pop":
                        sb.AppendLine(queue.Count > 0 ? queue.Dequeue().ToString() : "-1");
                        break;
                    case "size":
                        sb.AppendLine(queue.Count.ToString());
                        break;
                    case "empty":
                        sb.AppendLine(queue.Count == 0 ? "1" : "0");
                        break;
                    case "front":
                        sb.AppendLine(queue.Count > 0 ? queue.Peek().ToString() : "-1");
                        break;
                    case "back":
                        sb.AppendLine(queue.Count > 0 ? queue.Cast<int>().Last().ToString() : "-1");
                        break;

                }
            }
            Console.WriteLine(sb.ToString());
        }

    }
}