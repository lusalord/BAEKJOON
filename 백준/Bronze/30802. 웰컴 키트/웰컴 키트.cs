using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            string[] sizes = Console.ReadLine().Split();
            int[] shirtSizes = new int[6];
            for (int i = 0; i < 6; i++)
            {
                shirtSizes[i] = int.Parse(sizes[i]);
            }

            string[] tp = Console.ReadLine().Split();
            int T = int.Parse(tp[0]);
            int P = int.Parse(tp[1]);


            int totalShirtBundles = 0;
            for (int i = 0; i < 6; i++)
            {
                totalShirtBundles += (shirtSizes[i] + T - 1) / T;
            }


            int penBundles = N / P;
            int individualPens = N % P;


            Console.WriteLine(totalShirtBundles);
            Console.WriteLine($"{penBundles} {individualPens}");
        }
    }
}