using System;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine()); // 테스트 케이스 개수 입력

        for (int i = 0; i < T; i++)
        {
            string s = Console.ReadLine(); // 문자열 입력
            char first = s[0]; // 첫 번째 문자
            char last = s[s.Length - 1]; // 마지막 문자

            Console.WriteLine($"{first}{last}"); // 이어서 출력
        }
    }
}
