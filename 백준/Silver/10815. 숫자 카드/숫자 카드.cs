using System;
using System.IO;
using System.Linq;
using System.Text;


namespace BAEKJOON
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);

            int b = int.Parse(Console.ReadLine());
            int[] arr2 = new int[b];
            arr2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            
            for(int i = 0; i < arr2.Length; i++)
            {
                int min = 0;
                int max = arr.Length - 1;
                bool found = false;
                while (min <= max)
                {
                    int mid = (min + max) / 2;
                    if (arr[mid] < arr2[i])
                    {
                        min = mid + 1;
                    }
                    else if (arr[mid] > arr2[i])
                    {
                        max = mid - 1;
                    }
                    else if (arr[mid] == arr2[i])
                    {
                        found = true;
                        break;
                    }
                }
                sb.Append(found ? "1 " : "0 ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}