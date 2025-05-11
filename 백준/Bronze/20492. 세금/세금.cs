using System.Text;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            float b = 0;
            float c = 0;
            float d = 0;

            b = a * 0.78f;
            c = (22f / 100f) * a;
            d = c * 0.2f;
            Console.Write(Math.Round(b) + " ");
            Console.Write(a - d);
        }
    }
}