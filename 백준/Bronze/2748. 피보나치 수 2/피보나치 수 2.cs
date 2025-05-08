using System.Text;

namespace BAEKJOON
{
    internal class Program
    {
        public static long[] arr = new long[100];
        public static long Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            
            if (arr[n] != 0)
                return arr[n];
            
            arr[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
            
            return arr[n];
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(a));
        }
    }
}