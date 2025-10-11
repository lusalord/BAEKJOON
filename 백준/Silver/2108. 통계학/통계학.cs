using System;
using System.IO;
using System.Linq;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            int a = int.Parse(sr.ReadLine());
            int[] arr = new int[a];

            for (int i = 0; i < a; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }
            Array.Sort(arr);
            // 1. 산술평균
            Console.WriteLine(Avarage(arr));

            // 2. 중앙값
            Console.WriteLine(Middle(a, arr));

            // 3. 최빈값
            Console.WriteLine(Mode(arr));

            // 4. 범위
            Console.WriteLine(Range(a, arr));

        }

        private static int Range(int a, int[] arr)
        {
            return arr[a - 1] - arr[0];
        }

        public static int Mode(int[] arr)
        {

            int min = arr.Min();
            int max = arr.Max();
            int offset = -min;

            int[] count = new int[max - min + 1];

            for (int i = 0; i < arr.Length; i++)
                count[arr[i] + offset]++;

            int maxCount = 0;
            for (int i = 0; i < count.Length; i++)
                if (count[i] > maxCount)
                    maxCount = count[i];

            int[] modes = new int[count.Length];
            int modeCount = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] == maxCount)
                {
                    modes[modeCount++] = i - offset;
                }
            }

            if (modeCount > 1)
            {
                Array.Sort(modes, 0, modeCount);
                return modes[1];
            }

            return modes[0];
        }

        private static int Middle(int a, int[] arr)
        {
            Array.Sort(arr);
            return arr[a / 2];

        }

        private static int Avarage(int[] arr)
        {
            double avg = arr.Average();
            return (int)Math.Round(avg, 0, MidpointRounding.AwayFromZero);
        }

    }
}