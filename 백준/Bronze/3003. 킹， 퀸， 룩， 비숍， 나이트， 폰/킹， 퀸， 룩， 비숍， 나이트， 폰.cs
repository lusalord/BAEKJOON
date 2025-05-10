using System.Text;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1, 1, 2, 2, 2, 8};
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] - arr2[i] + " ");
            }

        }
    }
}