namespace BAEKJOON
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                int sum = 0;
                for (int i = 2; i <= n; i++)
                {
                    sum = a + b;
                    a = b;
                    b = sum;
                }

                Console.WriteLine(sum);
            }
        }

    }
}