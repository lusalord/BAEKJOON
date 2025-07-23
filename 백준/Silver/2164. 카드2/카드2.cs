using System;
using System.Collections.Generic;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();

            for (int i = 1; i <= a; i++)
            {
                queue.Enqueue(i);
            }

            while (queue.Count > 1)
            {
                queue.Dequeue(); // 맨 앞 요소 제거
                int front = queue.Dequeue(); // 다음 요소 제거
                queue.Enqueue(front); // 제거한 요소를 맨 뒤에 추가
            }
            // 마지막 남은 요소 출력
            Console.WriteLine(queue.Dequeue());
        }
    }
}