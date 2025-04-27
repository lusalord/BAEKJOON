namespace BAEKJOON
{
    internal class Program
    {
        static void aa(int a, int b)
        {
              Console.WriteLine((a+b)*(a-b));  
        }
        static void Main(string[] args)
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            aa(a[0], a[1]);
        }
    }
}