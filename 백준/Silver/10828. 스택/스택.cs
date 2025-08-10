using System;
using System.Collections;
using System.Linq;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main()
        {
            Stack stack = new Stack();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                if (command.StartsWith("push"))
                {
                    int value = int.Parse(command.Split(' ')[1]);
                    stack.Push(value);
                }
                else if (command == "pop")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Pop());
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (command == "size")
                {
                    Console.WriteLine(stack.Count);
                }
                else if (command == "empty")
                {
                    Console.WriteLine(stack.Count == 0 ? 1 : 0);
                }
                else if (command == "top")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Peek());
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
            }
        }
    }
}