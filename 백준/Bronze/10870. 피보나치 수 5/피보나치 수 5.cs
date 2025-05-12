using System.Text;

namespace BAEKJOON
{
    internal class Program
    {
        static public int Fibonacci(int n)
        {
            switch (n)
            {
                case 0: return 0;
                case 1: return 1;
                default: return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(a));
        }
    }
}