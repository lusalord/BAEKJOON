using System;
using System.Text;

class Program
{
    static void Main()
    {
        int testCaseCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < testCaseCount; i++)
        {
            string[] inputs = Console.ReadLine().Split();
            int repeatCount = int.Parse(inputs[0]);
            string inputString = inputs[1];

            StringBuilder result = new StringBuilder();

            foreach (char c in inputString)
            {
                result.Append(new string(c, repeatCount));
            }

            Console.WriteLine(result.ToString());
        }
    }
}
